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
    /// Форма для просмотра и редактирования таблицы "Медиа_файл".
    /// Поля "тип_файла" и "качество" отображаются как выпадающие списки с фиксированными значениями.
    /// Реализует привязку данных, навигацию, редактирование и паттерн Singleton.
    /// </summary>
    public partial class MediaFileListForm : Form
    {
        #region Singleton

        private static MediaFileListForm _instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static MediaFileListForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new MediaFileListForm();
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
        public MediaFileListForm()
        {
            InitializeComponent();
            mediaFileDataGridView.DataError += MediaFileDataGridView_DataError;
        }

        #endregion

        #region Загрузка данных

        /// <summary>
        /// Обработчик события загрузки формы.
        /// Заполняет таблицу "Медиа_файл" данными из базы данных через TableAdapter.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void MediaFileListForm_Load(object sender, EventArgs e)
        {
            this.mediaFileTableAdapter.Fill(this.videoHostingDBDataSet.Медиа_файл);
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
        private void MediaFileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mediaFileBindingSource.EndEdit();
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
        private void MediaFileDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            GridErrorHelper.ShowComboBoxError("Выберите значение из выпадающего списка.");
        }

        #endregion
    }
}
