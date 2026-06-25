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
        #region Singleton

        private static ContentListForm instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static ContentListForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new ContentListForm();
                return instance;
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
            this.contentTableAdapter.Fill(this.videoHostingDBDataSet.Контент);
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
        private void ContentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videoHostingDBDataSet);
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
