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
    /// Форма для просмотра и редактирования таблицы "Договор".
    /// Поле "тип_лицензии" отображается как выпадающий список с фиксированными значениями.
    /// Реализует привязку данных, навигацию, редактирование и паттерн Singleton.
    /// </summary>
    public partial class ContractListForm : Form
    {
        #region Singleton

        private static ContractListForm _instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static ContractListForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new ContractListForm();
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
        /// Инициализирует компоненты формы и подписывается на обработку ошибок ввода в DataGridView.
        /// </summary>
        public ContractListForm()
        {
            InitializeComponent();
            contractDataGridView.DataError += ContractDataGridView_DataError;
        }

        #endregion

        #region Загрузка данных

        /// <summary>
        /// Обработчик события загрузки формы.
        /// Заполняет таблицу "Договор" данными из базы данных через TableAdapter.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ContractListForm_Load(object sender, EventArgs e)
        {
            this.contractTableAdapter.Fill(this.videoHostingDBDataSet.Договор);
            AddExistingTerritoriesToComboBoxItems();
        }

        #endregion

        #region Сохранение данных

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить" в BindingNavigator.
        /// Выполняет проверку введённых данных, завершает редактирование
        /// и сохраняет все изменения в базу данных.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ContractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.contractBindingSource.EndEdit();
                EnsureContractTerritoriesAreValid();
                this.tableAdapterManager.UpdateAll(this.videoHostingDBDataSet);
                MessageBox.Show("Данные сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Обработка ошибок

        /// <summary>
        /// Обработчик ошибок DataGridView. Подавляет стандартное окно ошибки и показывает понятное сообщение.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события, содержащие индекс колонки с ошибкой.</param>

        private void AddExistingTerritoriesToComboBoxItems()
        {
            foreach (DataRow row in videoHostingDBDataSet.Договор.Rows)
            {
                if (row.IsNull("территория_действия"))
                    continue;

                var territory = Convert.ToString(row["территория_действия"]);
                if (!dataGridViewTextBoxColumn4.Items.Contains(territory))
                    dataGridViewTextBoxColumn4.Items.Add(territory);
            }
        }

        private void EnsureContractTerritoriesAreValid()
        {
            var allowedCountries = new HashSet<string>(GetCountryItems(), StringComparer.Ordinal);

            foreach (DataRow row in videoHostingDBDataSet.Договор.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                    continue;

                var territory = row.IsNull("территория_действия") ? string.Empty : Convert.ToString(row["территория_действия"]);
                if (!allowedCountries.Contains(territory))
                    throw new InvalidOperationException("В поле 'территория_действия' должна быть выбрана одна страна из списка. Исправьте старые значения вроде 'Весь мир' или 'США, Россия'.");
            }
        }

        private static IEnumerable<string> GetCountryItems()
        {
            return new[]
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
        private void ContractDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            GridErrorHelper.ShowComboBoxError("Выберите значение из списка. Для территории действия укажите одну страну.");
        }

        #endregion
    }
}
