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
    /// Форма для просмотра и редактирования таблицы "Лицензия".
    /// Поле "статус" является бинарным (bit) и отображается как CheckBox.
    /// Реализован паттерн Singleton для единственного экземпляра формы.
    /// </summary>
    public partial class LicenseListForm : Form
    {
        #region Singleton

        private static LicenseListForm _instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static LicenseListForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new LicenseListForm();
                return _instance;
            }
        }

        /// <summary>
        /// Показывает форму и активирует её.
        /// </summary>
        public void ShowForm()
        {
            Show();
            Activate();
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Инициализирует компоненты формы.
        /// </summary>
        public LicenseListForm()
        {
            InitializeComponent();

            // Подписка на событие ошибок DataGridView
            licenseDataGridView.DataError += LicenseDataGridView_DataError;
            licenseBindingSource.CurrentChanged += LicenseBindingSource_CurrentChanged;
        }

        #endregion

        #region Загрузка данных

        /// <summary>
        /// Обработчик загрузки формы.
        /// Заполняет таблицу "Лицензия" данными из БД.
        /// </summary>
        private void LicenseListForm_Load(object sender, EventArgs e)
        {
            this.licenseTableAdapter.Fill(this.videoHostingDBDataSet.Лицензия);

            if (this.videoHostingDBDataSet.Лицензия.Columns.Contains("дата_добавления"))
                this.videoHostingDBDataSet.Лицензия.Columns["дата_добавления"].DefaultValue = DateTime.Today;

            PrepareCurrentLicenseDefaults();
        }

        #endregion

        #region Сохранение данных

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить".
        /// Сохраняет изменения в базу данных с обработкой ошибок.
        /// </summary>
        private void LicenseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                PrepareCurrentLicenseDefaults();
                this.licenseBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.videoHostingDBDataSet);
                MessageBox.Show("Данные успешно сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Обработка ошибок DataGridView

        /// <summary>
        /// Обработчик ошибок DataGridView. Подавляет стандартное окно ошибки и показывает понятное сообщение.
        /// </summary>
        private void LicenseBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            PrepareCurrentLicenseDefaults();
        }

        private void PrepareCurrentLicenseDefaults()
        {
            var current = licenseBindingSource.Current as DataRowView;
            if (current == null || current.Row.RowState != DataRowState.Added)
                return;

            SetDefaultIfEmpty(current.Row, "дата_начала", DateTime.Today);
            SetDefaultIfEmpty(current.Row, "дата_окончания", DateTime.Today.AddYears(1));
            SetDefaultIfEmpty(current.Row, "статус", true);
            SetDefaultIfEmpty(current.Row, "дата_добавления", DateTime.Today);
        }

        private static void SetDefaultIfEmpty(DataRow row, string columnName, object value)
        {
            if (row.Table.Columns.Contains(columnName) && row.IsNull(columnName))
                row[columnName] = value;
        }
        private void LicenseDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            GridErrorHelper.ShowComboBoxError("Ошибка в данных. Проверьте правильность заполнения полей.");
        }

        #endregion
    }
}
