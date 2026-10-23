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
    /// Форма для просмотра и редактирования таблицы "Контент".
    /// Реализует привязку данных, навигацию, редактирование полей,
    /// загрузку изображений для постера и паттерн Singleton.
    /// </summary>
    public partial class ContentListForm : Form
    {
        private readonly VideoHostingDBDataSetTableAdapters.ЛицензияTableAdapter licensesTableAdapter =
            new VideoHostingDBDataSetTableAdapters.ЛицензияTableAdapter();
        private readonly VideoHostingDBDataSetTableAdapters.Медиа_файлTableAdapter mediaFilesTableAdapter =
            new VideoHostingDBDataSetTableAdapters.Медиа_файлTableAdapter();
        #region Singleton

        private static ContentListForm _instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static ContentListForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new ContentListForm();
                return _instance;
            }
        }

        private void ConfigureChildNavigator(BindingNavigator navigator, ToolStripButton saveButton,
            BindingSource source, string saveText, EventHandler saveHandler)
        {
            navigator.BindingSource = source;
            navigator.Dock = DockStyle.Top;
            navigator.GripStyle = ToolStripGripStyle.Hidden;
            saveButton.Text = saveText;
            saveButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveButton.Click += saveHandler;
            navigator.Items.Add(saveButton);
        }

        private void ConfigureChildGrid(DataGridView grid, BindingSource source,
            DataGridViewRowEventHandler defaultsHandler, DataGridViewDataErrorEventHandler errorHandler)
        {
            grid.Dock = DockStyle.Fill;
            grid.AutoGenerateColumns = true;
            grid.AllowUserToAddRows = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.DataSource = source;
            grid.DefaultValuesNeeded += defaultsHandler;
            grid.DataError += errorHandler;
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
        /// Инициализирует компоненты формы и заполняет выпадающие списки
        /// для полей "возрастной рейтинг" и "тип контента".
        /// </summary>
        public ContentListForm()
        {
            InitializeComponent();

            // Заполнение ComboBox для возрастного рейтинга
            ageRatingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ageRatingComboBox.Items.AddRange(new object[] { "0+", "6+", "12+", "16+", "18+" });

            // Заполнение ComboBox для типа контента
            contentTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            contentTypeComboBox.Items.AddRange(new object[]
            {
                "Фильм",
                "Мультфильм",
                "Сериал",
                "Мультсериал",
                "Короткометражный фильм",
                "Трейлер"
            });
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                contentLicensesBindingSource.DataSource = contentBindingSource;
                contentLicensesBindingSource.DataMember = "FK_Лицензия_Контент";
                mediaFilesBindingSource.DataSource = contentBindingSource;
                mediaFilesBindingSource.DataMember = "FK_Контент_Медиа_файл";
            }
        }

        private void ContentLicensesDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            SetContentForeignKey(e.Row);
        }

        private void MediaFilesDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            SetContentForeignKey(e.Row);
        }

        private void SetContentForeignKey(DataGridViewRow row)
        {
            DataRowView parent = contentBindingSource.Current as DataRowView;
            if (parent != null && row.Cells["ID_контента"] != null)
                row.Cells["ID_контента"].Value = parent["ID_контента"];
        }

        private void ContentLicensesDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Не удалось изменить лицензию. Проверьте обязательные поля и даты.\n" +
                (e.Exception == null ? string.Empty : e.Exception.Message), "Ошибка лицензии",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MediaFilesDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Не удалось изменить медиафайл. Проверьте обязательные поля и числовой размер.\n" +
                (e.Exception == null ? string.Empty : e.Exception.Message), "Ошибка медиафайла",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ContentLicensesSaveButton_Click(object sender, EventArgs e)
        {
            SaveRelatedContentData(contentLicensesBindingSource, licensesTableAdapter, "лицензий");
        }

        private void MediaFilesSaveButton_Click(object sender, EventArgs e)
        {
            SaveRelatedContentData(mediaFilesBindingSource, mediaFilesTableAdapter, "медиафайлов");
        }

        private void SaveRelatedContentData(BindingSource source, object adapter, string caption)
        {
            try
            {
                Validate();
                source.EndEdit();
                if (adapter is VideoHostingDBDataSetTableAdapters.ЛицензияTableAdapter)
                    ((VideoHostingDBDataSetTableAdapters.ЛицензияTableAdapter)adapter).Update(videoHostingDBDataSet.Лицензия);
                else
                    ((VideoHostingDBDataSetTableAdapters.Медиа_файлTableAdapter)adapter).Update(videoHostingDBDataSet.Медиа_файл);
                MessageBox.Show("Изменения " + caption + " сохранены.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении " + caption + ":\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Загрузка данных

        /// <summary>
        /// Обработчик события загрузки формы.
        /// Заполняет таблицу "Контент" данными из базы данных через TableAdapter.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ContentListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.contentTableAdapter.Fill(this.videoHostingDBDataSet.Контент);
                this.licensesTableAdapter.Fill(this.videoHostingDBDataSet.Лицензия);
                this.mediaFilesTableAdapter.Fill(this.videoHostingDBDataSet.Медиа_файл);
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
        private void ContentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.contentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.videoHostingDBDataSet);
                MessageBox.Show("Данные успешно сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Загрузка изображения постера

        /// <summary>
        /// Обработчик нажатия кнопки для загрузки изображения постера.
        /// Открывает диалог выбора файла, загружает изображение в PictureBox
        /// и сразу обновляет текущую запись в DataSet.
        /// </summary>
        private void openPhotoButton_Click(object sender, EventArgs e)
        {
            photoOpenFileDialog.Title = "Выберите файл постера";
            photoOpenFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif";

            if (photoOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Загружаем изображение в PictureBox
                    posterPictureBox.Image = new System.Drawing.Bitmap(photoOpenFileDialog.FileName);

                    // Конвертируем изображение в массив байтов
                    ImageConverter converter = new ImageConverter();
                    byte[] imageBytes = (byte[])converter.ConvertTo(posterPictureBox.Image, typeof(byte[]));

                    // Получаем текущую строку из BindingSource и обновляем поле "постер"
                    DataRowView currentRow = (DataRowView)contentBindingSource.Current;
                    if (currentRow != null)
                    {
                        currentRow["постер"] = imageBytes;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить изображение: " + ex.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}
