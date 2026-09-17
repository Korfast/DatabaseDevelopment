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
            contractBindingSource.CurrentChanged += ContractBindingSource_CurrentChanged;
            licenseBindingSource.CurrentChanged += LicenseBindingSource_CurrentChanged;
            licenseAddNewButton.Click += LicenseAddNewButton_Click;
            ConfigureTerritoryComboBox();
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
            contentTableAdapter.Fill(videoHostingDBDataSet.Контент);
            contractTableAdapter.Fill(videoHostingDBDataSet.Договор);
            licenseTableAdapter.Fill(videoHostingDBDataSet.Лицензия);

            // Для новых лицензий задаём дату добавления по умолчанию,
            // иначе при сохранении уйдёт NULL и БД отклонит вставку.
            if (videoHostingDBDataSet.Лицензия.Columns.Contains("дата_добавления"))
                videoHostingDBDataSet.Лицензия.Columns["дата_добавления"].DefaultValue = DateTime.Today;

            PrepareCurrentContractDefaults();
            PrepareCurrentLicenseDefaults();
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
                PrepareCurrentContractDefaults();
                PrepareCurrentLicenseDefaults();
                contractBindingSource.EndEdit();
                EnsureCurrentContractTerritoryIsValid();
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
                PrepareCurrentLicenseDefaults();
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

        private void ContractBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            PrepareCurrentContractDefaults();
        }

        private void LicenseBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            PrepareCurrentLicenseDefaults();
        }

        private void LicenseAddNewButton_Click(object sender, EventArgs e)
        {
            PrepareCurrentLicenseDefaults();
        }

        private void ConfigureTerritoryComboBox()
        {
            territoryComboBox.Items.Clear();
            territoryComboBox.Items.AddRange(GetCountryItems());
        }

        private static object[] GetCountryItems()
        {
            return new object[]
            {
                "Argentina", "Australia", "Austria", "Belarus", "Belgium", "Brazil", "Bulgaria", "Canada",
                "Chile", "China", "Colombia", "Croatia", "Czech Republic", "Denmark", "Egypt", "Finland",
                "France", "Germany", "Greece", "Hungary", "India", "Ireland", "Israel", "Italy", "Japan",
                "Kazakhstan", "Kenya", "Malaysia", "Mexico", "Netherlands", "New Zealand", "Nigeria", "Norway",
                "Pakistan", "Peru", "Philippines", "Poland", "Portugal", "Romania", "Russia", "Saudi Arabia",
                "Serbia", "Singapore", "Slovakia", "Slovenia", "South Africa", "South Korea", "Spain", "Sweden",
                "Switzerland", "Thailand", "Turkey", "UAE", "Ukraine", "United Kingdom", "USA", "Uzbekistan",
                "Venezuela", "Vietnam"
            };
        }

        private void PrepareCurrentContractDefaults()
        {
            var current = contractBindingSource.Current as DataRowView;
            if (current == null || current.Row.RowState != DataRowState.Added)
                return;

            SetDefaultIfEmpty(current.Row, "дата_заключения", DateTime.Today);
            SetDefaultIfEmpty(current.Row, "тип_лицензии", "VOD");
            SetDefaultIfEmpty(current.Row, "территория_действия", "Russia");
        }

        private void PrepareCurrentLicenseDefaults()
        {
            var current = licenseBindingSource.Current as DataRowView;
            if (current == null || current.Row.RowState != DataRowState.Added)
                return;

            var contract = contractBindingSource.Current as DataRowView;
            if (contract != null && !contract.Row.IsNull("номер_договора"))
                SetDefaultIfEmpty(current.Row, "номер_договора", contract.Row["номер_договора"]);

            SetDefaultIfEmpty(current.Row, "дата_начала", DateTime.Today);
            SetDefaultIfEmpty(current.Row, "дата_окончания", DateTime.Today.AddYears(1));
            SetDefaultIfEmpty(current.Row, "статус", true);
            SetDefaultIfEmpty(current.Row, "дата_добавления", DateTime.Today);
        }


        private void EnsureCurrentContractTerritoryIsValid()
        {
            var current = contractBindingSource.Current as DataRowView;
            if (current == null)
                return;

            var territory = Convert.ToString(current.Row["территория_действия"]);
            if (IsValidCountry(territory))
                return;

            throw new InvalidOperationException("Выберите одну страну в поле 'Территория действия'. Старые значения вроде 'Весь мир' или 'США, Россия' нужно заменить на одно государство из списка.");
        }

        private static bool IsValidCountry(string value)
        {
            return GetCountryItems()
                .Cast<object>()
                .Any(item => string.Equals(Convert.ToString(item), value, StringComparison.Ordinal));
        }
        private static void SetDefaultIfEmpty(DataRow row, string columnName, object value)
        {
            if (row.Table.Columns.Contains(columnName) && row.IsNull(columnName))
                row[columnName] = value;
        }
        private void LicenseDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            GridErrorHelper.ShowComboBoxError("Проверьте корректность введённого значения.");
        }

        #endregion
    }
}
