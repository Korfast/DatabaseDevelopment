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
    public partial class MediaFileListForm : Form
    {
        #region Singleton
        private static MediaFileListForm instance;
        public static MediaFileListForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new MediaFileListForm();
                return instance;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        #endregion

        #region Конструктор
        public MediaFileListForm()
        {
            InitializeComponent();
            mediaFileDataGridView.DataError += MediaFileDataGridView_DataError;
        }
        #endregion

        #region Загрузка
        private void MediaFileListForm_Load(object sender, EventArgs e)
        {
            this.mediaFileTableAdapter.Fill(this.videoHostingDBDataSet.Медиа_файл);
        }
        #endregion

        #region Сохранение
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
        private void MediaFileDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Выберите значение из выпадающего списка.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
    }
}
