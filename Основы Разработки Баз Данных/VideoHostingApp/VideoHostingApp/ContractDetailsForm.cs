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
    /// Форма для работы с договором и его лицензиями (связь 1:М).
    /// Договор отображается в режиме Details (родитель), лицензии — в гриде (дети).
    /// Показывает подстановочное (lookup) поле с наименованием правообладателя.
    /// </summary>
    public partial class ContractDetailsForm : Form
    {
        #region Singleton

        private static ContractDetailsForm _instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static ContractDetailsForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new ContractDetailsForm();
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
        /// Инициализирует компоненты формы и добавляет подстановочную колонку
        /// с наименованием правообладателя и лицензии — с названием контента.
        /// </summary>
        public ContractDetailsForm()
        {
            InitializeComponent();

            if (!videoHostingDBDataSet.Договор.Columns.Contains("Правообладатель_Наименование"))
            {
                videoHostingDBDataSet.Договор.Columns.Add(
                    "Правообладатель_Наименование", typeof(string),
                    "Parent(FK_Договор_Правообладатель).наименование");
            }

            if (!videoHostingDBDataSet.Лицензия.Columns.Contains("Контент_Название"))
            {
                videoHostingDBDataSet.Лицензия.Columns.Add(
                    "Контент_Название", typeof(string),
                    "Parent(FK_Лицензия_Контент).название");
            }

            licenseDataGridView.DataError += LicenseDataGridView_DataError;
        }

        #endregion

        #region Загрузка данных

        /// <summary>
        /// Заполняет данные договоров, правообладателей (для подстановочного поля)
        /// и лицензий (дочерние записи для текущего договора).
        /// </summary>
        private void ContractDetailsForm_Load(object sender, EventArgs e)
        {
            rightHolderTableAdapter.Fill(videoHostingDBDataSet.Правообладатель);
            contractTableAdapter.Fill(videoHostingDBDataSet.Договор);
            licenseTableAdapter.Fill(videoHostingDBDataSet.Лицензия);

            // Столбец "дата_добавления" (NOT NULL, DEFAULT getdate() в БД) отсутствует
            // в типизированном классе ЛицензияDataTable, но ADO.NET добавляет его
            // в таблицу на лету при Fill. Для новых строк нужно явное значение
            // по умолчанию, иначе при сохранении уйдёт NULL и БД отклонит вставку.
            if (videoHostingDBDataSet.Лицензия.Columns.Contains("дата_добавления"))
                videoHostingDBDataSet.Лицензия.Columns["дата_добавления"].DefaultValue = DateTime.Today;
        }

        #endregion

        #region Сохранение данных

        /// <summary>
        /// Сохраняет изменения по договору. Обрабатывает типичные ошибки:
        /// дублирование номера договора, несуществующий правообладатель (FK),
        /// нарушение формата номера договора или пути к скану (CHECK).
        /// </summary>
        private void ContractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                contractBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(videoHostingDBDataSet);
                MessageBox.Show("Данные договора сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении договора:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохраняет изменения по лицензиям текущего договора.
        /// </summary>
        private void LicenseSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                licenseBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(videoHostingDBDataSet);
                MessageBox.Show("Данные лицензий сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении лицензий:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Обработка ошибок

        private void LicenseDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            GridErrorHelper.ShowComboBoxError("Проверьте корректность введённого значения.");
        }

        #endregion
    }
}
