namespace VideoHostingApp
{
    public partial class RightHolderListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RightHolderListForm));
            this.videoHostingDBDataSet = new VideoHostingApp.VideoHostingDBDataSet();
            this.rightHolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rightHolderTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.ПравообладательTableAdapter();
            this.tableAdapterManager = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.TableAdapterManager();
            this.rightHolderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rightHolderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rightHolderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightHolderSearchPanel = new System.Windows.Forms.Panel();
            this.rightHolderSearchLabel = new System.Windows.Forms.Label();
            this.rightHolderSearchTextBox = new System.Windows.Forms.TextBox();
            this.rightHolderSearchButton = new System.Windows.Forms.Button();
            this.rightHolderResetSearchButton = new System.Windows.Forms.Button();
            this.contractsPanel = new System.Windows.Forms.Panel();
            this.contractsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.contractsSaveButton = new System.Windows.Forms.ToolStripButton();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHolderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHolderBindingNavigator)).BeginInit();
            this.rightHolderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightHolderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            this.contractsPanel.SuspendLayout();
            this.rightHolderSearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoHostingDBDataSet
            // 
            this.videoHostingDBDataSet.DataSetName = "VideoHostingDBDataSet";
            this.videoHostingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rightHolderBindingSource
            // 
            this.rightHolderBindingSource.DataMember = "Правообладатель";
            this.rightHolderBindingSource.DataSource = this.videoHostingDBDataSet;
            // 
            // rightHolderTableAdapter
            // 
            this.rightHolderTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Медиа_файлTableAdapter = null;
            this.tableAdapterManager.ПравообладательTableAdapter = this.rightHolderTableAdapter;
            // 
            // rightHolderBindingNavigator
            // 
            this.rightHolderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rightHolderBindingNavigator.BindingSource = this.rightHolderBindingSource;
            this.rightHolderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rightHolderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rightHolderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rightHolderBindingNavigatorSaveItem});
            this.rightHolderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rightHolderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rightHolderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rightHolderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rightHolderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rightHolderBindingNavigator.Name = "rightHolderBindingNavigator";
            this.rightHolderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rightHolderBindingNavigator.Size = new System.Drawing.Size(684, 25);
            this.rightHolderBindingNavigator.TabIndex = 0;
            this.rightHolderBindingNavigator.Text = "bindingNavigator1";
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
            // rightHolderBindingNavigatorSaveItem
            // 
            this.rightHolderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightHolderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rightHolderBindingNavigatorSaveItem.Image")));
            this.rightHolderBindingNavigatorSaveItem.Name = "rightHolderBindingNavigatorSaveItem";
            this.rightHolderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rightHolderBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.rightHolderBindingNavigatorSaveItem.Click += new System.EventHandler(this.RightHolderBindingNavigatorSaveItem_Click);
            // 
            // rightHolderDataGridView
            // 
            this.rightHolderDataGridView.AutoGenerateColumns = false;
            this.rightHolderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rightHolderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rightHolderDataGridView.DataSource = this.rightHolderBindingSource;
            this.rightHolderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightHolderDataGridView.Location = new System.Drawing.Point(0, 61);
            this.rightHolderDataGridView.Name = "rightHolderDataGridView";
            this.rightHolderDataGridView.Size = new System.Drawing.Size(684, 350);
            this.rightHolderDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_правообладателя";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_правообладателя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "страна_регистрации";
            this.dataGridViewTextBoxColumn3.HeaderText = "страна_регистрации";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "Argentina",
            "Australia",
            "Austria",
            "Belarus",
            "Belgium",
            "Brazil",
            "Bulgaria",
            "Canada",
            "Chile",
            "China",
            "Colombia",
            "Croatia",
            "Czech Republic",
            "Denmark",
            "Egypt",
            "Finland",
            "France",
            "Germany",
            "Greece",
            "Hungary",
            "India",
            "Ireland",
            "Israel",
            "Italy",
            "Japan",
            "Kazakhstan",
            "Kenya",
            "Malaysia",
            "Mexico",
            "Netherlands",
            "New Zealand",
            "Nigeria",
            "Norway",
            "Pakistan",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Romania",
            "Russia",
            "Saudi Arabia",
            "Serbia",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "South Africa",
            "South Korea",
            "Spain",
            "Sweden",
            "Switzerland",
            "Thailand",
            "Turkey",
            "UAE",
            "Ukraine",
            "United Kingdom",
            "USA",
            "Uzbekistan",
            "Venezuela",
            "Vietnam"});
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "контактное_лицо";
            this.dataGridViewTextBoxColumn4.HeaderText = "контактное_лицо";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // rightHolderSearchPanel
            // 
            this.rightHolderSearchPanel.Controls.Add(this.rightHolderSearchLabel);
            this.rightHolderSearchPanel.Controls.Add(this.rightHolderSearchTextBox);
            this.rightHolderSearchPanel.Controls.Add(this.rightHolderSearchButton);
            this.rightHolderSearchPanel.Controls.Add(this.rightHolderResetSearchButton);
            this.rightHolderSearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightHolderSearchPanel.Location = new System.Drawing.Point(0, 25);
            this.rightHolderSearchPanel.Name = "rightHolderSearchPanel";
            this.rightHolderSearchPanel.Padding = new System.Windows.Forms.Padding(8, 6, 8, 4);
            this.rightHolderSearchPanel.Size = new System.Drawing.Size(684, 36);
            this.rightHolderSearchPanel.TabIndex = 1;
            // 
            // rightHolderSearchLabel
            // 
            this.rightHolderSearchLabel.AutoSize = true;
            this.rightHolderSearchLabel.Location = new System.Drawing.Point(8, 10);
            this.rightHolderSearchLabel.Name = "rightHolderSearchLabel";
            this.rightHolderSearchLabel.Size = new System.Drawing.Size(116, 13);
            this.rightHolderSearchLabel.TabIndex = 0;
            this.rightHolderSearchLabel.Text = "Поиск по названию:";
            // 
            // rightHolderSearchTextBox
            // 
            this.rightHolderSearchTextBox.Location = new System.Drawing.Point(130, 7);
            this.rightHolderSearchTextBox.Name = "rightHolderSearchTextBox";
            this.rightHolderSearchTextBox.Size = new System.Drawing.Size(240, 20);
            this.rightHolderSearchTextBox.TabIndex = 1;
            this.rightHolderSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RightHolderSearchTextBox_KeyDown);
            // 
            // rightHolderSearchButton
            // 
            this.rightHolderSearchButton.Location = new System.Drawing.Point(380, 5);
            this.rightHolderSearchButton.Name = "rightHolderSearchButton";
            this.rightHolderSearchButton.Size = new System.Drawing.Size(75, 23);
            this.rightHolderSearchButton.TabIndex = 2;
            this.rightHolderSearchButton.Text = "Найти";
            this.rightHolderSearchButton.UseVisualStyleBackColor = true;
            this.rightHolderSearchButton.Click += new System.EventHandler(this.RightHolderSearchButton_Click);
            // 
            // rightHolderResetSearchButton
            // 
            this.rightHolderResetSearchButton.Location = new System.Drawing.Point(463, 5);
            this.rightHolderResetSearchButton.Name = "rightHolderResetSearchButton";
            this.rightHolderResetSearchButton.Size = new System.Drawing.Size(75, 23);
            this.rightHolderResetSearchButton.TabIndex = 3;
            this.rightHolderResetSearchButton.Text = "Сброс";
            this.rightHolderResetSearchButton.UseVisualStyleBackColor = true;
            this.rightHolderResetSearchButton.Click += new System.EventHandler(this.RightHolderResetSearchButton_Click);
            // contractsPanel
            this.contractsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractsPanel.Controls.Add(this.contractsDataGridView);
            this.contractsPanel.Controls.Add(this.contractsBindingNavigator);
            this.contractsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contractsPanel.Height = 190;
            this.contractsPanel.Name = "contractsPanel";
            this.contractsPanel.Padding = new System.Windows.Forms.Padding(4);
            // contractsBindingNavigator
            this.contractsBindingNavigator.BindingSource = this.contractsBindingSource;
            this.contractsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.contractsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.contractsBindingNavigator.Items.Add(this.contractsSaveButton);
            this.contractsBindingNavigator.Name = "contractsBindingNavigator";
            // contractsSaveButton
            this.contractsSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.contractsSaveButton.Text = "Сохранить договоры";
            this.contractsSaveButton.Click += new System.EventHandler(this.ContractsSaveButton_Click);
            // contractsDataGridView
            this.contractsDataGridView.AllowUserToAddRows = true;
            this.contractsDataGridView.AutoGenerateColumns = true;
            this.contractsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contractsDataGridView.DataSource = this.contractsBindingSource;
            this.contractsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ContractsDataGridView_DefaultValuesNeeded);
            this.contractsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ContractsDataGridView_DataError);
            // 
            // RightHolderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.rightHolderDataGridView);
            this.Controls.Add(this.contractsPanel);
            this.Controls.Add(this.rightHolderSearchPanel);
            this.Controls.Add(this.rightHolderBindingNavigator);
            this.Name = "RightHolderListForm";
            this.Text = "Список правообладателей";
            this.Load += new System.EventHandler(this.RightHolderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHolderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHolderBindingNavigator)).EndInit();
            this.rightHolderBindingNavigator.ResumeLayout(false);
            this.rightHolderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightHolderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
            this.contractsPanel.ResumeLayout(false);
            this.rightHolderSearchPanel.ResumeLayout(false);
            this.rightHolderSearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoHostingDBDataSet videoHostingDBDataSet;
        private System.Windows.Forms.BindingSource rightHolderBindingSource;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private VideoHostingDBDataSetTableAdapters.ПравообладательTableAdapter rightHolderTableAdapter;
        private VideoHostingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rightHolderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rightHolderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rightHolderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel rightHolderSearchPanel;
        private System.Windows.Forms.Label rightHolderSearchLabel;
        private System.Windows.Forms.TextBox rightHolderSearchTextBox;
        private System.Windows.Forms.Button rightHolderSearchButton;
        private System.Windows.Forms.Button rightHolderResetSearchButton;
    }
}
