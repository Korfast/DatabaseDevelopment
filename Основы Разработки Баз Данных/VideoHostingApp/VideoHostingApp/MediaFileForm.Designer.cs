namespace VideoHostingApp
{
    partial class MediaFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaFileForm));
            this.videoHostingDBDataSet = new VideoHostingApp.VideoHostingDBDataSet();
            this.mediaFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaFileTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.Медиа_файлTableAdapter();
            this.tableAdapterManager = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.TableAdapterManager();
            this.mediaFileBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mediaFileBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mediaFileDataGridView = new System.Windows.Forms.DataGridView();
            this.iDфайлаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDконтентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типфайлаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.качествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.путьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mediaFileBindingNavigatorSaveItem
            // 
            this.mediaFileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mediaFileBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mediaFileBindingNavigatorSaveItem.Image")));
            this.mediaFileBindingNavigatorSaveItem.Name = "mediaFileBindingNavigatorSaveItem";
            this.mediaFileBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mediaFileBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.mediaFileBindingNavigatorSaveItem.Click += new System.EventHandler(this.MediaFileBindingNavigatorSaveItem_Click);
            // 
            // mediaFileDataGridView
            // 
            this.mediaFileDataGridView.AllowUserToAddRows = false;
            this.mediaFileDataGridView.AutoGenerateColumns = false;
            this.mediaFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaFileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDфайлаDataGridViewTextBoxColumn,
            this.iDконтентаDataGridViewTextBoxColumn,
            this.типфайлаDataGridViewTextBoxColumn,
            this.качествоDataGridViewTextBoxColumn,
            this.путьDataGridViewTextBoxColumn,
            this.размерDataGridViewTextBoxColumn,
            this.языкDataGridViewTextBoxColumn});
            this.mediaFileDataGridView.DataSource = this.mediaFileBindingSource;
            this.mediaFileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaFileDataGridView.Location = new System.Drawing.Point(0, 25);
            this.mediaFileDataGridView.Name = "mediaFileDataGridView";
            this.mediaFileDataGridView.Size = new System.Drawing.Size(834, 386);
            this.mediaFileDataGridView.TabIndex = 1;
            // 
            // iDфайлаDataGridViewTextBoxColumn
            // 
            this.iDфайлаDataGridViewTextBoxColumn.DataPropertyName = "ID_файла";
            this.iDфайлаDataGridViewTextBoxColumn.HeaderText = "ID_файла";
            this.iDфайлаDataGridViewTextBoxColumn.Name = "iDфайлаDataGridViewTextBoxColumn";
            this.iDфайлаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDконтентаDataGridViewTextBoxColumn
            // 
            this.iDконтентаDataGridViewTextBoxColumn.DataPropertyName = "ID_контента";
            this.iDконтентаDataGridViewTextBoxColumn.HeaderText = "ID_контента";
            this.iDконтентаDataGridViewTextBoxColumn.Name = "iDконтентаDataGridViewTextBoxColumn";
            // 
            // типфайлаDataGridViewTextBoxColumn
            // 
            this.типфайлаDataGridViewTextBoxColumn.DataPropertyName = "тип_файла";
            this.типфайлаDataGridViewTextBoxColumn.HeaderText = "тип_файла";
            this.типфайлаDataGridViewTextBoxColumn.Name = "типфайлаDataGridViewTextBoxColumn";
            this.типфайлаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.типфайлаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // качествоDataGridViewTextBoxColumn
            // 
            this.качествоDataGridViewTextBoxColumn.DataPropertyName = "качество";
            this.качествоDataGridViewTextBoxColumn.HeaderText = "качество";
            this.качествоDataGridViewTextBoxColumn.Name = "качествоDataGridViewTextBoxColumn";
            this.качествоDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.качествоDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // путьDataGridViewTextBoxColumn
            // 
            this.путьDataGridViewTextBoxColumn.DataPropertyName = "путь";
            this.путьDataGridViewTextBoxColumn.HeaderText = "путь";
            this.путьDataGridViewTextBoxColumn.Name = "путьDataGridViewTextBoxColumn";
            // 
            // размерDataGridViewTextBoxColumn
            // 
            this.размерDataGridViewTextBoxColumn.DataPropertyName = "размер";
            this.размерDataGridViewTextBoxColumn.HeaderText = "размер";
            this.размерDataGridViewTextBoxColumn.Name = "размерDataGridViewTextBoxColumn";
            // 
            // языкDataGridViewTextBoxColumn
            // 
            this.языкDataGridViewTextBoxColumn.DataPropertyName = "язык";
            this.языкDataGridViewTextBoxColumn.HeaderText = "язык";
            this.языкDataGridViewTextBoxColumn.Name = "языкDataGridViewTextBoxColumn";
            // 
            // MediaFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.mediaFileDataGridView);
            this.Controls.Add(this.mediaFileBindingNavigator);
            this.Name = "MediaFileForm";
            this.Text = "Список медиафайлов";
            this.Load += new System.EventHandler(this.MediaFileForm_Load);
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
        private VideoHostingApp.VideoHostingDBDataSetTableAdapters.Медиа_файлTableAdapter mediaFileTableAdapter;
        private VideoHostingApp.VideoHostingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDфайлаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDконтентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn типфайлаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn качествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn путьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкDataGridViewTextBoxColumn;
    }
}