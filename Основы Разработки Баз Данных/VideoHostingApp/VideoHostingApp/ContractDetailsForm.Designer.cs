namespace VideoHostingApp
{
    partial class ContractDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractDetailsForm));
            this.videoHostingDBDataSet = new VideoHostingApp.VideoHostingDBDataSet();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.ДоговорTableAdapter();
            this.rightHolderTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.ПравообладательTableAdapter();
            this.licenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licenseTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.ЛицензияTableAdapter();
            this.tableAdapterManager = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.TableAdapterManager();
            this.contractBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contractBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contractNumberLabel = new System.Windows.Forms.Label();
            this.contractNumberTextBox = new System.Windows.Forms.TextBox();
            this.conclusionDateLabel = new System.Windows.Forms.Label();
            this.conclusionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rightHolderIdLabel = new System.Windows.Forms.Label();
            this.rightHolderIdTextBox = new System.Windows.Forms.TextBox();
            this.rightHolderNameCaptionLabel = new System.Windows.Forms.Label();
            this.rightHolderNameLabel = new System.Windows.Forms.Label();
            this.territoryLabel = new System.Windows.Forms.Label();
            this.territoryTextBox = new System.Windows.Forms.TextBox();
            this.licenseTypeLabel = new System.Windows.Forms.Label();
            this.licenseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.scanPathLabel = new System.Windows.Forms.Label();
            this.scanPathTextBox = new System.Windows.Forms.TextBox();
            this.licensesGroupBox = new System.Windows.Forms.GroupBox();
            this.licenseDataGridView = new System.Windows.Forms.DataGridView();
            this.licenseIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseContentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseContentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseStartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseEndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseStatusColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.licenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.licenseAddNewButton = new System.Windows.Forms.ToolStripButton();
            this.licenseDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.licenseSaveButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).BeginInit();
            this.contractBindingNavigator.SuspendLayout();
            this.licensesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingNavigator)).BeginInit();
            this.licenseBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            //
            // videoHostingDBDataSet
            //
            this.videoHostingDBDataSet.DataSetName = "VideoHostingDBDataSet";
            this.videoHostingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //
            // contractBindingSource
            //
            this.contractBindingSource.DataMember = "Договор";
            this.contractBindingSource.DataSource = this.videoHostingDBDataSet;
            //
            // contractTableAdapter
            //
            this.contractTableAdapter.ClearBeforeFill = true;
            //
            // rightHolderTableAdapter
            //
            this.rightHolderTableAdapter.ClearBeforeFill = true;
            //
            // licenseBindingSource
            //
            this.licenseBindingSource.DataMember = "FK_Лицензия_Договор";
            this.licenseBindingSource.DataSource = this.contractBindingSource;
            //
            // licenseTableAdapter
            //
            this.licenseTableAdapter.ClearBeforeFill = true;
            //
            // tableAdapterManager
            //
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = VideoHostingApp.VideoHostingDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговорTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.ЖанрTableAdapter = null;
            this.tableAdapterManager.Контент_ЖанрTableAdapter = null;
            this.tableAdapterManager.КонтентTableAdapter = null;
            this.tableAdapterManager.ЛицензияTableAdapter = this.licenseTableAdapter;
            this.tableAdapterManager.Медиа_файлTableAdapter = null;
            this.tableAdapterManager.ПравообладательTableAdapter = this.rightHolderTableAdapter;
            //
            // contractBindingNavigator
            //
            this.contractBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractBindingNavigator.BindingSource = this.contractBindingSource;
            this.contractBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contractBindingNavigatorSaveItem});
            this.contractBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractBindingNavigator.Name = "contractBindingNavigator";
            this.contractBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractBindingNavigator.Size = new System.Drawing.Size(760, 25);
            this.contractBindingNavigator.TabIndex = 0;
            this.contractBindingNavigator.Text = "bindingNavigator1";
            //
            // bindingNavigatorAddNewItem
            //
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить запись";
            this.bindingNavigatorAddNewItem.ToolTipText = "Добавить запись";
            //
            // bindingNavigatorCountItem
            //
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число записей";
            //
            // bindingNavigatorDeleteItem
            //
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить запись";
            this.bindingNavigatorDeleteItem.ToolTipText = "Удалить запись";
            //
            // bindingNavigatorMoveFirstItem
            //
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Первая запись, в начало";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "Первая запись, в начало";
            //
            // bindingNavigatorMovePreviousItem
            //
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Предыдущая запись, назад";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "Предыдущая запись, назад";
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
            this.bindingNavigatorMoveNextItem.Text = "Следующая запись, вперед";
            this.bindingNavigatorMoveNextItem.ToolTipText = "Следующая запись, вперед";
            //
            // bindingNavigatorMoveLastItem
            //
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Последняя запись, в конец";
            this.bindingNavigatorMoveLastItem.ToolTipText = "Последняя запись, в конец";
            //
            // bindingNavigatorSeparator2
            //
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            //
            // contractBindingNavigatorSaveItem
            //
            this.contractBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractBindingNavigatorSaveItem.Image")));
            this.contractBindingNavigatorSaveItem.Name = "contractBindingNavigatorSaveItem";
            this.contractBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contractBindingNavigatorSaveItem.Text = "Сохранить";
            this.contractBindingNavigatorSaveItem.ToolTipText = "Сохранить данные";
            this.contractBindingNavigatorSaveItem.Click += new System.EventHandler(this.ContractBindingNavigatorSaveItem_Click);
            //
            // contractNumberLabel
            //
            this.contractNumberLabel.AutoSize = true;
            this.contractNumberLabel.Location = new System.Drawing.Point(12, 38);
            this.contractNumberLabel.Name = "contractNumberLabel";
            this.contractNumberLabel.Size = new System.Drawing.Size(112, 13);
            this.contractNumberLabel.Text = "Номер договора:";
            //
            // contractNumberTextBox
            //
            this.contractNumberTextBox.Location = new System.Drawing.Point(160, 35);
            this.contractNumberTextBox.Name = "contractNumberTextBox";
            this.contractNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.contractNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "номер_договора", true));
            //
            // conclusionDateLabel
            //
            this.conclusionDateLabel.AutoSize = true;
            this.conclusionDateLabel.Location = new System.Drawing.Point(12, 64);
            this.conclusionDateLabel.Name = "conclusionDateLabel";
            this.conclusionDateLabel.Size = new System.Drawing.Size(110, 13);
            this.conclusionDateLabel.Text = "Дата заключения:";
            //
            // conclusionDateTimePicker
            //
            this.conclusionDateTimePicker.Location = new System.Drawing.Point(160, 61);
            this.conclusionDateTimePicker.Name = "conclusionDateTimePicker";
            this.conclusionDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.conclusionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "дата_заключения", true));
            //
            // rightHolderIdLabel
            //
            this.rightHolderIdLabel.AutoSize = true;
            this.rightHolderIdLabel.Location = new System.Drawing.Point(12, 90);
            this.rightHolderIdLabel.Name = "rightHolderIdLabel";
            this.rightHolderIdLabel.Size = new System.Drawing.Size(103, 13);
            this.rightHolderIdLabel.Text = "ID правообладателя:";
            //
            // rightHolderIdTextBox
            //
            this.rightHolderIdTextBox.Location = new System.Drawing.Point(160, 87);
            this.rightHolderIdTextBox.Name = "rightHolderIdTextBox";
            this.rightHolderIdTextBox.Size = new System.Drawing.Size(80, 20);
            this.rightHolderIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ID_правообладателя", true));
            //
            // rightHolderNameCaptionLabel
            //
            this.rightHolderNameCaptionLabel.AutoSize = true;
            this.rightHolderNameCaptionLabel.Location = new System.Drawing.Point(12, 116);
            this.rightHolderNameCaptionLabel.Name = "rightHolderNameCaptionLabel";
            this.rightHolderNameCaptionLabel.Size = new System.Drawing.Size(87, 13);
            this.rightHolderNameCaptionLabel.Text = "Правообладатель:";
            //
            // rightHolderNameLabel
            //
            this.rightHolderNameLabel.AutoSize = true;
            this.rightHolderNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rightHolderNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.rightHolderNameLabel.Location = new System.Drawing.Point(160, 116);
            this.rightHolderNameLabel.Name = "rightHolderNameLabel";
            this.rightHolderNameLabel.Size = new System.Drawing.Size(13, 15);
            this.rightHolderNameLabel.Text = "-";
            this.rightHolderNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Правообладатель_Наименование", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            //
            // territoryLabel
            //
            this.territoryLabel.AutoSize = true;
            this.territoryLabel.Location = new System.Drawing.Point(12, 142);
            this.territoryLabel.Name = "territoryLabel";
            this.territoryLabel.Size = new System.Drawing.Size(112, 13);
            this.territoryLabel.Text = "Территория действия:";
            //
            // territoryTextBox
            //
            this.territoryTextBox.Location = new System.Drawing.Point(160, 139);
            this.territoryTextBox.Name = "territoryTextBox";
            this.territoryTextBox.Size = new System.Drawing.Size(280, 20);
            this.territoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "территория_действия", true));
            //
            // licenseTypeLabel
            //
            this.licenseTypeLabel.AutoSize = true;
            this.licenseTypeLabel.Location = new System.Drawing.Point(12, 168);
            this.licenseTypeLabel.Name = "licenseTypeLabel";
            this.licenseTypeLabel.Size = new System.Drawing.Size(75, 13);
            this.licenseTypeLabel.Text = "Тип лицензии:";
            //
            // licenseTypeComboBox
            //
            this.licenseTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.licenseTypeComboBox.Items.AddRange(new object[] {
            "CC0",
            "CC BY",
            "CC BY-SA",
            "CC BY-ND",
            "CC BY-NC",
            "CC BY-NC-SA",
            "CC BY-NC-ND",
            "Полная",
            "VOD",
            "ТВ",
            "Театральный прокат",
            "Ограниченная",
            "Эксклюзивная",
            "Неисключительная",
            "Сублицензия"});
            this.licenseTypeComboBox.Location = new System.Drawing.Point(160, 165);
            this.licenseTypeComboBox.Name = "licenseTypeComboBox";
            this.licenseTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.licenseTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.contractBindingSource, "тип_лицензии", true));
            //
            // scanPathLabel
            //
            this.scanPathLabel.AutoSize = true;
            this.scanPathLabel.Location = new System.Drawing.Point(12, 194);
            this.scanPathLabel.Name = "scanPathLabel";
            this.scanPathLabel.Size = new System.Drawing.Size(80, 13);
            this.scanPathLabel.Text = "Путь к скану:";
            //
            // scanPathTextBox
            //
            this.scanPathTextBox.Location = new System.Drawing.Point(160, 191);
            this.scanPathTextBox.Name = "scanPathTextBox";
            this.scanPathTextBox.Size = new System.Drawing.Size(280, 20);
            this.scanPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "путь_к_скану", true));
            //
            // licensesGroupBox
            //
            this.licensesGroupBox.Controls.Add(this.licenseBindingNavigator);
            this.licensesGroupBox.Controls.Add(this.licenseDataGridView);
            this.licensesGroupBox.Location = new System.Drawing.Point(12, 224);
            this.licensesGroupBox.Name = "licensesGroupBox";
            this.licensesGroupBox.Size = new System.Drawing.Size(736, 260);
            this.licensesGroupBox.TabStop = false;
            this.licensesGroupBox.Text = "Лицензии по договору";
            //
            // licenseDataGridView
            //
            this.licenseDataGridView.AllowUserToAddRows = false;
            this.licenseDataGridView.AutoGenerateColumns = false;
            this.licenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.licenseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licenseIdColumn,
            this.licenseContentIdColumn,
            this.licenseContentNameColumn,
            this.licenseStartDateColumn,
            this.licenseEndDateColumn,
            this.licenseStatusColumn});
            this.licenseDataGridView.DataSource = this.licenseBindingSource;
            this.licenseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenseDataGridView.Location = new System.Drawing.Point(3, 41);
            this.licenseDataGridView.Name = "licenseDataGridView";
            this.licenseDataGridView.Size = new System.Drawing.Size(730, 216);
            this.licenseDataGridView.TabIndex = 1;
            //
            // licenseIdColumn
            //
            this.licenseIdColumn.DataPropertyName = "ID_лицензии";
            this.licenseIdColumn.HeaderText = "ID_лицензии";
            this.licenseIdColumn.Name = "licenseIdColumn";
            this.licenseIdColumn.ReadOnly = true;
            this.licenseIdColumn.Width = 80;
            //
            // licenseContentIdColumn
            //
            this.licenseContentIdColumn.DataPropertyName = "ID_контента";
            this.licenseContentIdColumn.HeaderText = "ID_контента";
            this.licenseContentIdColumn.Name = "licenseContentIdColumn";
            this.licenseContentIdColumn.Width = 90;
            //
            // licenseContentNameColumn
            //
            this.licenseContentNameColumn.DataPropertyName = "Контент_Название";
            this.licenseContentNameColumn.HeaderText = "Контент";
            this.licenseContentNameColumn.Name = "licenseContentNameColumn";
            this.licenseContentNameColumn.ReadOnly = true;
            this.licenseContentNameColumn.Width = 180;
            //
            // licenseStartDateColumn
            //
            this.licenseStartDateColumn.DataPropertyName = "дата_начала";
            this.licenseStartDateColumn.HeaderText = "Дата начала";
            this.licenseStartDateColumn.Name = "licenseStartDateColumn";
            this.licenseStartDateColumn.Width = 100;
            //
            // licenseEndDateColumn
            //
            this.licenseEndDateColumn.DataPropertyName = "дата_окончания";
            this.licenseEndDateColumn.HeaderText = "Дата окончания";
            this.licenseEndDateColumn.Name = "licenseEndDateColumn";
            this.licenseEndDateColumn.Width = 100;
            //
            // licenseStatusColumn
            //
            this.licenseStatusColumn.DataPropertyName = "статус";
            this.licenseStatusColumn.HeaderText = "Статус";
            this.licenseStatusColumn.Name = "licenseStatusColumn";
            this.licenseStatusColumn.Width = 60;
            //
            // licenseBindingNavigator
            //
            this.licenseBindingNavigator.AddNewItem = this.licenseAddNewButton;
            this.licenseBindingNavigator.BindingSource = this.licenseBindingSource;
            this.licenseBindingNavigator.CountItem = null;
            this.licenseBindingNavigator.DeleteItem = this.licenseDeleteButton;
            this.licenseBindingNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.licenseBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.licenseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseAddNewButton,
            this.licenseDeleteButton,
            this.licenseSaveButton});
            this.licenseBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.licenseBindingNavigator.MoveFirstItem = null;
            this.licenseBindingNavigator.MoveLastItem = null;
            this.licenseBindingNavigator.MoveNextItem = null;
            this.licenseBindingNavigator.MovePreviousItem = null;
            this.licenseBindingNavigator.Name = "licenseBindingNavigator";
            this.licenseBindingNavigator.PositionItem = null;
            this.licenseBindingNavigator.Size = new System.Drawing.Size(730, 25);
            this.licenseBindingNavigator.TabIndex = 0;
            this.licenseBindingNavigator.Text = "licenseBindingNavigator";
            //
            // licenseAddNewButton
            //
            this.licenseAddNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.licenseAddNewButton.Name = "licenseAddNewButton";
            this.licenseAddNewButton.Size = new System.Drawing.Size(70, 22);
            this.licenseAddNewButton.Text = "Добавить";
            this.licenseAddNewButton.ToolTipText = "Добавить лицензию";
            //
            // licenseDeleteButton
            //
            this.licenseDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.licenseDeleteButton.Name = "licenseDeleteButton";
            this.licenseDeleteButton.Size = new System.Drawing.Size(60, 22);
            this.licenseDeleteButton.Text = "Удалить";
            this.licenseDeleteButton.ToolTipText = "Удалить лицензию";
            //
            // licenseSaveButton
            //
            this.licenseSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.licenseSaveButton.Name = "licenseSaveButton";
            this.licenseSaveButton.Size = new System.Drawing.Size(70, 22);
            this.licenseSaveButton.Text = "Сохранить";
            this.licenseSaveButton.ToolTipText = "Сохранить лицензии";
            this.licenseSaveButton.Click += new System.EventHandler(this.LicenseSaveButton_Click);
            //
            // ContractDetailsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 496);
            this.Controls.Add(this.licensesGroupBox);
            this.Controls.Add(this.scanPathTextBox);
            this.Controls.Add(this.scanPathLabel);
            this.Controls.Add(this.licenseTypeComboBox);
            this.Controls.Add(this.licenseTypeLabel);
            this.Controls.Add(this.territoryTextBox);
            this.Controls.Add(this.territoryLabel);
            this.Controls.Add(this.rightHolderNameLabel);
            this.Controls.Add(this.rightHolderNameCaptionLabel);
            this.Controls.Add(this.rightHolderIdTextBox);
            this.Controls.Add(this.rightHolderIdLabel);
            this.Controls.Add(this.conclusionDateTimePicker);
            this.Controls.Add(this.conclusionDateLabel);
            this.Controls.Add(this.contractNumberTextBox);
            this.Controls.Add(this.contractNumberLabel);
            this.Controls.Add(this.contractBindingNavigator);
            this.Name = "ContractDetailsForm";
            this.Text = "Договор";
            this.Load += new System.EventHandler(this.ContractDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingNavigator)).EndInit();
            this.contractBindingNavigator.ResumeLayout(false);
            this.contractBindingNavigator.PerformLayout();
            this.licensesGroupBox.ResumeLayout(false);
            this.licensesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingNavigator)).EndInit();
            this.licenseBindingNavigator.ResumeLayout(false);
            this.licenseBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoHostingDBDataSet videoHostingDBDataSet;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private VideoHostingDBDataSetTableAdapters.ДоговорTableAdapter contractTableAdapter;
        private VideoHostingDBDataSetTableAdapters.ПравообладательTableAdapter rightHolderTableAdapter;
        private System.Windows.Forms.BindingSource licenseBindingSource;
        private VideoHostingDBDataSetTableAdapters.ЛицензияTableAdapter licenseTableAdapter;
        private VideoHostingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contractBindingNavigatorSaveItem;
        private System.Windows.Forms.Label contractNumberLabel;
        private System.Windows.Forms.TextBox contractNumberTextBox;
        private System.Windows.Forms.Label conclusionDateLabel;
        private System.Windows.Forms.DateTimePicker conclusionDateTimePicker;
        private System.Windows.Forms.Label rightHolderIdLabel;
        private System.Windows.Forms.TextBox rightHolderIdTextBox;
        private System.Windows.Forms.Label rightHolderNameCaptionLabel;
        private System.Windows.Forms.Label rightHolderNameLabel;
        private System.Windows.Forms.Label territoryLabel;
        private System.Windows.Forms.TextBox territoryTextBox;
        private System.Windows.Forms.Label licenseTypeLabel;
        private System.Windows.Forms.ComboBox licenseTypeComboBox;
        private System.Windows.Forms.Label scanPathLabel;
        private System.Windows.Forms.TextBox scanPathTextBox;
        private System.Windows.Forms.GroupBox licensesGroupBox;
        private System.Windows.Forms.DataGridView licenseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseContentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseContentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseStartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseEndDateColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn licenseStatusColumn;
        private System.Windows.Forms.BindingNavigator licenseBindingNavigator;
        private System.Windows.Forms.ToolStripButton licenseAddNewButton;
        private System.Windows.Forms.ToolStripButton licenseDeleteButton;
        private System.Windows.Forms.ToolStripButton licenseSaveButton;
    }
}
