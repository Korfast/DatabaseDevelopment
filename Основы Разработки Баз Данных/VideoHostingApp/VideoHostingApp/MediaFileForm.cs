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
    public partial class MediaFileForm : Form
    {
        #region Singleton
        private static MediaFileForm instance;
        public static MediaFileForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new MediaFileForm();
                return instance;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        #endregion

        public MediaFileForm()
        {
            InitializeComponent();

            // 1. Отключаем автогенерацию
            mediaFileDataGridView.AutoGenerateColumns = false;

            // 2. Очищаем все колонки
            mediaFileDataGridView.Columns.Clear();

            // 3. Добавляем текстовые колонки
            mediaFileDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ID_файла",
                DataPropertyName = "ID_файла",
                HeaderText = "ID_файла",
                ReadOnly = true,
                Width = 80
            });
            mediaFileDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ID_контента",
                DataPropertyName = "ID_контента",
                HeaderText = "ID_контента",
                Width = 100
            });
            mediaFileDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "путь",
                DataPropertyName = "путь",
                HeaderText = "путь",
                Width = 200
            });
            mediaFileDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "размер",
                DataPropertyName = "размер",
                HeaderText = "размер",
                Width = 100
            });
            mediaFileDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "язык",
                DataPropertyName = "язык",
                HeaderText = "язык",
                Width = 100
            });

            // 4. Добавляем колонку "тип_файла" (ComboBox)
            DataGridViewComboBoxColumn typeCol = new DataGridViewComboBoxColumn();
            typeCol.Name = "тип_файла";
            typeCol.DataPropertyName = "тип_файла";
            typeCol.HeaderText = "тип_файла";
            typeCol.Items.AddRange(new object[] { "mp4", "avi", "mkv", "mov", "avc", "hevc", "wmv", "flv" });
            typeCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            typeCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            typeCol.Width = 120;
            mediaFileDataGridView.Columns.Add(typeCol);

            // 5. Добавляем колонку "качество" (ComboBox)
            DataGridViewComboBoxColumn qualityCol = new DataGridViewComboBoxColumn();
            qualityCol.Name = "качество";
            qualityCol.DataPropertyName = "качество";
            qualityCol.HeaderText = "качество";
            qualityCol.Items.AddRange(new object[] { "SD", "HD", "Full HD", "4K", "8K" });
            qualityCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            qualityCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            qualityCol.Width = 100;
            mediaFileDataGridView.Columns.Add(qualityCol);

            // 6. Привязываем источник данных (ПОСЛЕ добавления колонок!)
            mediaFileDataGridView.DataSource = mediaFileBindingSource;

            // 7. Обработчик ошибок
            mediaFileDataGridView.DataError += MediaFileDataGridView_DataError;
        }

        private void MediaFileForm_Load(object sender, EventArgs e)
        {
            this.mediaFileTableAdapter.Fill(this.videoHostingDBDataSet.Медиа_файл);
            // Выводим имена всех колонок в DataSet
            string names = "";
            foreach (DataColumn col in videoHostingDBDataSet.Медиа_файл.Columns)
                names += col.ColumnName + "\n";
            MessageBox.Show(names);
        }

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

        private void MediaFileDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            // В случае ошибки показываем сообщение с именем колонки
            MessageBox.Show($"Ошибка в колонке: {mediaFileDataGridView.Columns[e.ColumnIndex].Name}");
        }
    }
}
