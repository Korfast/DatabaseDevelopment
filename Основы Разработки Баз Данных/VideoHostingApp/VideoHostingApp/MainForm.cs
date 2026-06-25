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
    /// Главная форма приложения для управления видеохостингом.
    /// Содержит главное меню, контекстное меню, панель инструментов,
    /// а также обработчики для открытия справочных форм и выхода из приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Конструктор главной формы.
        /// Инициализирует компоненты формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #region Обработчики пунктов меню

        /// <summary>
        /// Обработчик нажатия пункта меню "Выход" или соответствующей кнопки.
        /// Закрывает главную форму, инициируя завершение приложения.
        /// </summary>
        /// <param name="sender">Источник события (пункт меню или кнопка).</param>
        /// <param name="e">Аргументы события.</param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработчик нажатия пункта меню "О программе".
        /// Отображает информационное окно с данными о разработчике и версии.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "(C) ТУСУР, КСУП, Фаст К.М., 574-2, 2026",
                    "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// Обработчик нажатия пункта меню "Контент".
        /// Открывает форму для просмотра и редактирования списка контента.
        /// В текущей версии используется заглушка (информационное сообщение).
        /// После создания формы ContentListForm следует заменить вызов на синглтон-экземпляр.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: после создания ContentListForm раскомментировать:
            ContentListForm.Instance.ShowForm();
            // MessageBox.Show("Форма Контент будет открыта позже.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик нажатия пункта меню "Правообладатели".
        /// Открывает форму для просмотра и редактирования списка правообладателей.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RightHoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: после создания RightHolderListForm
            // RightHolderListForm.Instance.ShowForm();
            MessageBox.Show("Форма Правообладатели будет открыта позже.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик нажатия пункта меню "Жанры".
        /// Открывает форму для просмотра и редактирования списка жанров.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void GenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: после создания GenreListForm
            // GenreListForm.Instance.ShowForm();
            MessageBox.Show("Форма Жанры будет открыта позже.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик нажатия пункта меню "Лицензии".
        /// Открывает форму для просмотра и редактирования списка лицензий.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void LicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: после создания LicenseListForm
            // LicenseListForm.Instance.ShowForm();
            MessageBox.Show("Форма Лицензии будет открыта позже.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик нажатия пункта меню "Договоры".
        /// Открывает форму для просмотра и редактирования списка договоров.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ContractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: после создания ContractListForm
            // ContractListForm.Instance.ShowForm();
            MessageBox.Show("Форма Договоры будет открыта позже.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик нажатия пункта меню "Медиафайлы".
        /// Открывает форму для просмотра и редактирования списка медиафайлов.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void MediaFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: после создания MediaFileListForm
            // MediaFileListForm.Instance.ShowForm();
            MessageBox.Show("Форма Медиафайлы будет открыта позже.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Обработчики кнопок панели инструментов

        // Кнопка "Выход" и "О программе" могут использовать те же обработчики,
        // что и соответствующие пункты меню (ExitToolStripMenuItem_Click, AboutToolStripMenuItem_Click).
        // Для кнопок справочников можно назначить соответствующие обработчики из региона выше.

        #endregion

        #region Сохранение положения окна и подтверждение закрытия

        /// <summary>
        /// Обработчик события закрытия формы (FormClosed).
        /// Сохраняет пользовательские настройки (положение окна и другие параметры)
        /// в файл конфигурации приложения.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Обработчик события, возникающего перед закрытием формы (FormClosing).
        /// Запрашивает у пользователя подтверждение на закрытие приложения.
        /// Если пользователь выбирает "Нет", закрытие отменяется.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события, содержащие флаг отмены.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите закрыть программу?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        #endregion
    }
}
