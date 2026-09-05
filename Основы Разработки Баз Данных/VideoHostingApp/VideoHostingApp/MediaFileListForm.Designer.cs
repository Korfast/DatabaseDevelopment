namespace VideoHostingApp
{
    partial class MediaFileListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaFileListForm));
            this.videoHostingDBDataSet = new VideoHostingApp.VideoHostingDBDataSet();
            this.mediaFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaFileTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.Медиа_файлTableAdapter();
            this.tableAdapterManager = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.TableAdapterManager();
            this.mediaFileBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mediaFileBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mediaFileDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileBindingNavigator)).BeginInit();
            this.mediaFileBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // videoHostingDBDataSet
            // 
            this.videoHostingDBDataSet.DataSetName = "VideoHostingDBDataSet";
            this.videoHostingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaFileBindingSource
            // 
            this.mediaFileBindingSource.DataMember = "Медиа_файл";
            this.mediaFileBindingSource.DataSource = this.videoHostingDBDataSet;
            // 
            // mediaFileTableAdapter
            // 
            this.mediaFileTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = VideoHostingApp.VideoHostingDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговорTableAdapter = null;
            this.tableAdapterManager.ЖанрTableAdapter = null;
            this.tableAdapterManager.Контент_ЖанрTableAdapter = null;
            this.tableAdapterManager.КонтентTableAdapter = null;
            this.tableAdapterManager.ЛицензияTableAdapter = null;
            this.tableAdapterManager.Медиа_файлTableAdapter = this.mediaFileTableAdapter;
            this.tableAdapterManager.ПравообладательTableAdapter = null;
            // 
            // mediaFileBindingNavigator
            // 
            this.mediaFileBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mediaFileBindingNavigator.BindingSource = this.mediaFileBindingSource;
            this.mediaFileBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mediaFileBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mediaFileBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mediaFileBindingNavigatorSaveItem});
            this.mediaFileBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mediaFileBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mediaFileBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mediaFileBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mediaFileBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mediaFileBindingNavigator.Name = "mediaFileBindingNavigator";
            this.mediaFileBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mediaFileBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.mediaFileBindingNavigator.TabIndex = 0;
            this.mediaFileBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // mediaFileBindingNavigatorSaveItem
            // 
            this.mediaFileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mediaFileBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mediaFileBindingNavigatorSaveItem.Image")));
            this.mediaFileBindingNavigatorSaveItem.Name = "медиа_файлBindingNavigatorSaveItem";
            this.mediaFileBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mediaFileBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.mediaFileBindingNavigatorSaveItem.Click += new System.EventHandler(this.MediaFileBindingNavigatorSaveItem_Click);
            // 
            // mediaFileDataGridView
            // 
            this.mediaFileDataGridView.AutoGenerateColumns = false;
            this.mediaFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaFileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.mediaFileDataGridView.DataSource = this.mediaFileBindingSource;
            this.mediaFileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaFileDataGridView.Location = new System.Drawing.Point(0, 25);
            this.mediaFileDataGridView.Name = "mediaFileDataGridView";
            this.mediaFileDataGridView.Size = new System.Drawing.Size(834, 386);
            this.mediaFileDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_файла";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_файла";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_контента";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_контента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "тип_файла";
            this.dataGridViewTextBoxColumn3.HeaderText = "тип_файла";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "mp4",
            "avi",
            "mkv",
            "mov",
            "avc",
            "hevc",
            "wmv",
            "flv"});
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "качество";
            this.dataGridViewTextBoxColumn4.HeaderText = "качество";
            this.dataGridViewTextBoxColumn4.Items.AddRange(new object[] {
            "SD",
            "HD",
            "Full HD",
            "4K",
            "8K"});
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "путь";
            this.dataGridViewTextBoxColumn5.HeaderText = "путь";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "размер";
            this.dataGridViewTextBoxColumn6.HeaderText = "размер";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "язык";
            this.dataGridViewTextBoxColumn7.HeaderText = "язык";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // MediaFileListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.mediaFileDataGridView);
            this.Controls.Add(this.mediaFileBindingNavigator);
            this.Name = "MediaFileListForm";
            this.Text = "Список медиафайлов";
            this.Load += new System.EventHandler(this.MediaFileListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileBindingNavigator)).EndInit();
            this.mediaFileBindingNavigator.ResumeLayout(false);
            this.mediaFileBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoHostingDBDataSet videoHostingDBDataSet;
        private System.Windows.Forms.BindingSource mediaFileBindingSource;
        private VideoHostingDBDataSetTableAdapters.Медиа_файлTableAdapter mediaFileTableAdapter;
        private VideoHostingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mediaFileBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mediaFileBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mediaFileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}