using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoHostingApp
{
    /// <summary>
    /// Форма для просмотра и редактирования таблицы "Правообладатель".
    /// Реализует привязку данных, навигацию, редактирование и паттерн Singleton.
    /// Поле "страна_регистрации" отображается как выпадающий список с фиксированными значениями.
    /// </summary>
    public partial class RightHolderListForm : Form
    {
        private readonly VideoHostingDBDataSetTableAdapters.ДоговорTableAdapter contractsTableAdapter =
            new VideoHostingDBDataSetTableAdapters.ДоговорTableAdapter();
        private DataGridView contractsDataGridView;
        private BindingNavigator contractsBindingNavigator;
        private Panel contractsPanel;
        private ToolStripButton contractsSaveButton;
        #region Singleton

        private static RightHolderListForm _instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static RightHolderListForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new RightHolderListForm();
                return _instance;
            }
        }

        /// <summary>
        /// Показывает форму и активирует её.
        /// Если форма уже открыта, просто переключает фокус на неё.
        /// </summary>
        public void ShowForm()
        {
            Show();
            Activate();
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Инициализирует компоненты формы и настраивает колонку "страна_регистрации" как выпадающий список.
        /// </summary>
        public RightHolderListForm()
        {
            InitializeComponent();
            InitializeRelatedContractsPanel();
        }

        /// <summary>
        /// Показывает договоры выбранного правообладателя прямо в справочнике.
        /// Дочерний источник использует связь DataSet, поэтому список автоматически
        /// меняется при переходе между правообладателями.
        /// </summary>
        private void InitializeRelatedContractsPanel()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
            contractsBindingSource.DataSource = rightHolderBindingSource;
            contractsBindingSource.DataMember = "FK_Договор_Правообладатель";
        }

        private void ContractsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DataRowView parent = rightHolderBindingSource.Current as DataRowView;
            if (parent != null && parent.Row.Table.Columns.Contains("ID_правообладателя"))
                e.Row.Cells["ID_правообладателя"].Value = parent["ID_правообладателя"];
        }

        private void ContractsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Не удалось изменить договор. Проверьте обязательные поля и формат даты.\n" +
                (e.Exception == null ? string.Empty : e.Exception.Message),
                "Ошибка договора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ContractsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                contractsBindingSource.EndEdit();
                contractsTableAdapter.Update(videoHostingDBDataSet.Договор);
                MessageBox.Show("Договоры успешно сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении договоров:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Поиск

        private void RightHolderSearchButton_Click(object sender, EventArgs e)
        {
            ApplyRightHolderSearch();
        }

        private void RightHolderResetSearchButton_Click(object sender, EventArgs e)
        {
            rightHolderSearchTextBox.Clear();
            rightHolderBindingSource.RemoveFilter();
        }

        private void RightHolderSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyRightHolderSearch();
                e.SuppressKeyPress = true;
            }
        }

        private void ApplyRightHolderSearch()
        {
            string searchText = rightHolderSearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                rightHolderBindingSource.RemoveFilter();
                return;
            }

            string escapedText = searchText
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");

            try
            {
                rightHolderBindingSource.Filter = string.Format("Convert([наименование], 'System.String') LIKE '%{0}%'", escapedText);
            }
            catch (Exception ex)
            {
                rightHolderBindingSource.RemoveFilter();
                MessageBox.Show("Ошибка поиска правообладателя:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region Загрузка данных

        /// <summary>
        /// Обработчик события загрузки формы.
        /// Заполняет таблицу "Правообладатель" данными из базы данных через TableAdapter.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RightHolderListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.rightHolderTableAdapter.Fill(this.videoHostingDBDataSet.Правообладатель);
                this.contractsTableAdapter.Fill(this.videoHostingDBDataSet.Договор);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Сохранение данных

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить" в BindingNavigator.
        /// Выполняет проверку введённых данных, завершает редактирование
        /// и сохраняет все изменения в базу данных.
        /// При возникновении ошибки (например, нарушение CHECK-ограничения)
        /// показывает информативное сообщение пользователю.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RightHolderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.rightHolderBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.videoHostingDBDataSet);
                MessageBox.Show("Данные успешно сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
