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
    /// Форма для работы с контентом и его жанрами (связь М:М через Контент_Жанр)
    /// и медиафайлами (связь 1:М). Контент отображается в режиме Details (родитель),
    /// жанры и медиафайлы — в гридах (дети).
    /// </summary>
    public partial class ContentDetailsForm : Form
    {
        #region Singleton

        private static ContentDetailsForm _instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static ContentDetailsForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new ContentDetailsForm();
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
        /// Инициализирует компоненты формы и добавляет вычисляемые колонки:
        /// полное название контента (строка) и размер медиафайла в мегабайтах (число).
        /// </summary>
        public ContentDetailsForm()
        {
            InitializeComponent();

            if (!videoHostingDBDataSet.Контент.Columns.Contains("Название_полное"))
            {
                videoHostingDBDataSet.Контент.Columns.Add(
                    "Название_полное", typeof(string),
                    "название+' ('+Convert(год_выпуска,'System.String')+')'");
            }

            if (!videoHostingDBDataSet.Медиа_файл.Columns.Contains("Размер_МБ"))
            {
                videoHostingDBDataSet.Медиа_файл.Columns.Add(
                    "Размер_МБ", typeof(decimal),
                    "размер/1024.0/1024.0");
            }

            genreLinkDataGridView.DataError += GenreLinkDataGridView_DataError;
        }

        #endregion

        #region Загрузка данных

        /// <summary>
        /// Заполняет данные контента, жанров (источник для выпадающего списка),
        /// связей контент-жанр и медиафайлов (дочерние записи для текущего контента).
        /// </summary>
        private void ContentDetailsForm_Load(object sender, EventArgs e)
        {
            genreTableAdapter.Fill(videoHostingDBDataSet.Жанр);
            contentTableAdapter.Fill(videoHostingDBDataSet.Контент);
            contentGenreTableAdapter.Fill(videoHostingDBDataSet.Контент_Жанр);
            mediaFileTableAdapter.Fill(videoHostingDBDataSet.Медиа_файл);
        }

        #endregion

        #region Сохранение данных

        /// <summary>
        /// Сохраняет изменения по контенту.
        /// </summary>
        private void ContentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                contentBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(videoHostingDBDataSet);
                MessageBox.Show("Данные контента сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении контента:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохраняет изменения по жанрам текущего контента.
        /// </summary>
        private void GenreLinkSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                genreLinkBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(videoHostingDBDataSet);
                MessageBox.Show("Жанры контента сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении жанров:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Обработка ошибок

        private void GenreLinkDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            GridErrorHelper.ShowComboBoxError("Выберите жанр из выпадающего списка.");
        }

        #endregion
    }
}
