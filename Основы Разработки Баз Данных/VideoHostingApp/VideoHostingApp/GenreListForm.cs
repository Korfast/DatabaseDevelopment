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
    /// Форма для просмотра и редактирования таблицы "Жанр".
    /// Реализует привязку данных, навигацию, редактирование и паттерн Singleton.
    /// </summary>
    public partial class GenreListForm : Form
    {
        #region Singleton

        private static GenreListForm instance;

        /// <summary>
        /// Возвращает единственный экземпляр формы.
        /// Если форма ещё не создана или была уничтожена, создаёт новый экземпляр.
        /// </summary>
        public static GenreListForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new GenreListForm();
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
        /// Инициализирует компоненты формы.
        /// </summary>
        public GenreListForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Загрузка данных

        /// <summary>
        /// Обработчик события загрузки формы.
        /// Заполняет таблицу "Жанр" данными из базы данных через TableAdapter.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void GenreListForm_Load(object sender, EventArgs e)
        {
            this.genreTableAdapter.Fill(this.videoHostingDBDataSet.Жанр);
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
        private void GenreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.genreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.videoHostingDBDataSet);
        }

        #endregion
    }
}
