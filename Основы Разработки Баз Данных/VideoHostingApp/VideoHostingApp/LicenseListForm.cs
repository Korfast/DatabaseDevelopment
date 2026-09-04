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

        private static LicenseListForm instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static LicenseListForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new LicenseListForm();
                return instance;
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
        private void LicenseDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Ошибка в данных. Проверьте правильность заполнения полей.",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion
    }
}
