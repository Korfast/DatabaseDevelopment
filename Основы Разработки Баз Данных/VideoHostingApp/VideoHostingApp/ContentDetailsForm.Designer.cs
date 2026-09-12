namespace VideoHostingApp
{
    partial class ContentDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentDetailsForm));
            this.videoHostingDBDataSet = new VideoHostingApp.VideoHostingDBDataSet();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.КонтентTableAdapter();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.ЖанрTableAdapter();
            this.genreLinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentGenreTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.Контент_ЖанрTableAdapter();
            this.mediaFileLinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaFileTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.Медиа_файлTableAdapter();
            this.tableAdapterManager = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.TableAdapterManager();
            this.contentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.fullTitleCaptionLabel = new System.Windows.Forms.Label();
            this.fullTitleLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.directorLabel = new System.Windows.Forms.Label();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.contentTypeLabel = new System.Windows.Forms.Label();
            this.contentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.genresGroupBox = new System.Windows.Forms.GroupBox();
            this.genreLinkDataGridView = new System.Windows.Forms.DataGridView();
            this.genreLinkContentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreLinkGenreIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.genreLinkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.genreLinkAddNewButton = new System.Windows.Forms.ToolStripButton();
            this.genreLinkDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.genreLinkSaveButton = new System.Windows.Forms.ToolStripButton();
            this.mediaFilesGroupBox = new System.Windows.Forms.GroupBox();
            this.mediaFileDataGridView = new System.Windows.Forms.DataGridView();
            this.mediaFileIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaFileTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaFileQualityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaFileSizeMbColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaFilePathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreLinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileLinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingNavigator)).BeginInit();
            this.contentBindingNavigator.SuspendLayout();
            this.genresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreLinkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreLinkBindingNavigator)).BeginInit();
            this.genreLinkBindingNavigator.SuspendLayout();
            this.mediaFilesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileDataGridView)).BeginInit();
            this.SuspendLayout();
            //
            // videoHostingDBDataSet
            //
            this.videoHostingDBDataSet.DataSetName = "VideoHostingDBDataSet";
            this.videoHostingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //
            // contentBindingSource
            //
            this.contentBindingSource.DataMember = "Контент";
            this.contentBindingSource.DataSource = this.videoHostingDBDataSet;
            //
            // contentTableAdapter
            //
            this.contentTableAdapter.ClearBeforeFill = true;
            //
            // genreBindingSource
            //
            this.genreBindingSource.DataMember = "Жанр";
            this.genreBindingSource.DataSource = this.videoHostingDBDataSet;
            //
            // genreTableAdapter
            //
            this.genreTableAdapter.ClearBeforeFill = true;
            //
            // genreLinkBindingSource
            //
            this.genreLinkBindingSource.DataMember = "FK_Контент_Контент_Жанр";
            this.genreLinkBindingSource.DataSource = this.contentBindingSource;
            //
            // contentGenreTableAdapter
            //
            this.contentGenreTableAdapter.ClearBeforeFill = true;
            //
            // mediaFileLinkBindingSource
            //
            this.mediaFileLinkBindingSource.DataMember = "FK_Контент_Медиа_файл";
            this.mediaFileLinkBindingSource.DataSource = this.contentBindingSource;
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
            this.tableAdapterManager.ЖанрTableAdapter = this.genreTableAdapter;
            this.tableAdapterManager.Контент_ЖанрTableAdapter = this.contentGenreTableAdapter;
            this.tableAdapterManager.КонтентTableAdapter = this.contentTableAdapter;
            this.tableAdapterManager.ЛицензияTableAdapter = null;
            this.tableAdapterManager.Медиа_файлTableAdapter = this.mediaFileTableAdapter;
            this.tableAdapterManager.ПравообладательTableAdapter = null;
            //
            // contentBindingNavigator
            //
            this.contentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contentBindingNavigator.BindingSource = this.contentBindingSource;
            this.contentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contentBindingNavigatorSaveItem});
            this.contentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contentBindingNavigator.Name = "contentBindingNavigator";
            this.contentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contentBindingNavigator.Size = new System.Drawing.Size(760, 25);
            this.contentBindingNavigator.TabIndex = 0;
            this.contentBindingNavigator.Text = "bindingNavigator1";
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
            // contentBindingNavigatorSaveItem
            //
            this.contentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contentBindingNavigatorSaveItem.Image")));
            this.contentBindingNavigatorSaveItem.Name = "contentBindingNavigatorSaveItem";
            this.contentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contentBindingNavigatorSaveItem.Text = "Сохранить";
            this.contentBindingNavigatorSaveItem.ToolTipText = "Сохранить данные";
            this.contentBindingNavigatorSaveItem.Click += new System.EventHandler(this.ContentBindingNavigatorSaveItem_Click);
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 38);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 13);
            this.titleLabel.Text = "Название:";
            //
            // titleTextBox
            //
            this.titleTextBox.Location = new System.Drawing.Point(150, 35);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(280, 20);
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "название", true));
            //
            // fullTitleCaptionLabel
            //
            this.fullTitleCaptionLabel.AutoSize = true;
            this.fullTitleCaptionLabel.Location = new System.Drawing.Point(12, 64);
            this.fullTitleCaptionLabel.Name = "fullTitleCaptionLabel";
            this.fullTitleCaptionLabel.Size = new System.Drawing.Size(100, 13);
            this.fullTitleCaptionLabel.Text = "Название с годом:";
            //
            // fullTitleLabel
            //
            this.fullTitleLabel.AutoSize = true;
            this.fullTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fullTitleLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.fullTitleLabel.Location = new System.Drawing.Point(150, 64);
            this.fullTitleLabel.Name = "fullTitleLabel";
            this.fullTitleLabel.Size = new System.Drawing.Size(13, 15);
            this.fullTitleLabel.Text = "-";
            this.fullTitleLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "Название_полное", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            //
            // yearLabel
            //
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 90);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(70, 13);
            this.yearLabel.Text = "Год выпуска:";
            //
            // yearTextBox
            //
            this.yearTextBox.Location = new System.Drawing.Point(150, 87);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(80, 20);
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "год_выпуска", true));
            //
            // directorLabel
            //
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(12, 116);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(56, 13);
            this.directorLabel.Text = "Режиссёр:";
            //
            // directorTextBox
            //
            this.directorTextBox.Location = new System.Drawing.Point(150, 113);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(280, 20);
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "режиссёр", true));
            //
            // contentTypeLabel
            //
            this.contentTypeLabel.AutoSize = true;
            this.contentTypeLabel.Location = new System.Drawing.Point(12, 142);
            this.contentTypeLabel.Name = "contentTypeLabel";
            this.contentTypeLabel.Size = new System.Drawing.Size(75, 13);
            this.contentTypeLabel.Text = "Тип контента:";
            //
            // contentTypeComboBox
            //
            this.contentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contentTypeComboBox.Items.AddRange(new object[] {
            "Фильм",
            "Мультфильм",
            "Сериал",
            "Мультсериал",
            "Короткометражный фильм",
            "Трейлер"});
            this.contentTypeComboBox.Location = new System.Drawing.Point(150, 139);
            this.contentTypeComboBox.Name = "contentTypeComboBox";
            this.contentTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.contentTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.contentBindingSource, "тип_контента", true));
            //
            // genresGroupBox
            //
            this.genresGroupBox.Controls.Add(this.genreLinkBindingNavigator);
            this.genresGroupBox.Controls.Add(this.genreLinkDataGridView);
            this.genresGroupBox.Location = new System.Drawing.Point(12, 172);
            this.genresGroupBox.Name = "genresGroupBox";
            this.genresGroupBox.Size = new System.Drawing.Size(736, 160);
            this.genresGroupBox.TabStop = false;
            this.genresGroupBox.Text = "Жанры контента (М:М через Контент_Жанр)";
            //
            // genreLinkDataGridView
            //
            this.genreLinkDataGridView.AllowUserToAddRows = false;
            this.genreLinkDataGridView.AutoGenerateColumns = false;
            this.genreLinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreLinkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreLinkContentIdColumn,
            this.genreLinkGenreIdColumn});
            this.genreLinkDataGridView.DataSource = this.genreLinkBindingSource;
            this.genreLinkDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreLinkDataGridView.Location = new System.Drawing.Point(3, 41);
            this.genreLinkDataGridView.Name = "genreLinkDataGridView";
            this.genreLinkDataGridView.Size = new System.Drawing.Size(730, 116);
            this.genreLinkDataGridView.TabIndex = 1;
            //
            // genreLinkContentIdColumn
            //
            this.genreLinkContentIdColumn.DataPropertyName = "ID_контента";
            this.genreLinkContentIdColumn.HeaderText = "ID_контента";
            this.genreLinkContentIdColumn.Name = "genreLinkContentIdColumn";
            this.genreLinkContentIdColumn.ReadOnly = true;
            this.genreLinkContentIdColumn.Width = 90;
            //
            // genreLinkGenreIdColumn
            //
            this.genreLinkGenreIdColumn.DataPropertyName = "ID_жанра";
            this.genreLinkGenreIdColumn.DataSource = this.genreBindingSource;
            this.genreLinkGenreIdColumn.DisplayMember = "Наименование";
            this.genreLinkGenreIdColumn.ValueMember = "ID_жанра";
            this.genreLinkGenreIdColumn.HeaderText = "Жанр";
            this.genreLinkGenreIdColumn.Name = "genreLinkGenreIdColumn";
            this.genreLinkGenreIdColumn.Width = 200;
            //
            // genreLinkBindingNavigator
            //
            this.genreLinkBindingNavigator.AddNewItem = this.genreLinkAddNewButton;
            this.genreLinkBindingNavigator.BindingSource = this.genreLinkBindingSource;
            this.genreLinkBindingNavigator.CountItem = null;
            this.genreLinkBindingNavigator.DeleteItem = this.genreLinkDeleteButton;
            this.genreLinkBindingNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.genreLinkBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.genreLinkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreLinkAddNewButton,
            this.genreLinkDeleteButton,
            this.genreLinkSaveButton});
            this.genreLinkBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.genreLinkBindingNavigator.MoveFirstItem = null;
            this.genreLinkBindingNavigator.MoveLastItem = null;
            this.genreLinkBindingNavigator.MoveNextItem = null;
            this.genreLinkBindingNavigator.MovePreviousItem = null;
            this.genreLinkBindingNavigator.Name = "genreLinkBindingNavigator";
            this.genreLinkBindingNavigator.PositionItem = null;
            this.genreLinkBindingNavigator.Size = new System.Drawing.Size(730, 25);
            this.genreLinkBindingNavigator.TabIndex = 0;
            this.genreLinkBindingNavigator.Text = "genreLinkBindingNavigator";
            //
            // genreLinkAddNewButton
            //
            this.genreLinkAddNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.genreLinkAddNewButton.Name = "genreLinkAddNewButton";
            this.genreLinkAddNewButton.Size = new System.Drawing.Size(70, 22);
            this.genreLinkAddNewButton.Text = "Добавить";
            this.genreLinkAddNewButton.ToolTipText = "Добавить жанр контенту";
            //
            // genreLinkDeleteButton
            //
            this.genreLinkDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.genreLinkDeleteButton.Name = "genreLinkDeleteButton";
            this.genreLinkDeleteButton.Size = new System.Drawing.Size(60, 22);
            this.genreLinkDeleteButton.Text = "Удалить";
            this.genreLinkDeleteButton.ToolTipText = "Убрать жанр у контента";
            //
            // genreLinkSaveButton
            //
            this.genreLinkSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.genreLinkSaveButton.Name = "genreLinkSaveButton";
            this.genreLinkSaveButton.Size = new System.Drawing.Size(70, 22);
            this.genreLinkSaveButton.Text = "Сохранить";
            this.genreLinkSaveButton.ToolTipText = "Сохранить жанры контента";
            this.genreLinkSaveButton.Click += new System.EventHandler(this.GenreLinkSaveButton_Click);
            //
            // mediaFilesGroupBox
            //
            this.mediaFilesGroupBox.Controls.Add(this.mediaFileDataGridView);
            this.mediaFilesGroupBox.Location = new System.Drawing.Point(12, 338);
            this.mediaFilesGroupBox.Name = "mediaFilesGroupBox";
            this.mediaFilesGroupBox.Size = new System.Drawing.Size(736, 146);
            this.mediaFilesGroupBox.TabStop = false;
            this.mediaFilesGroupBox.Text = "Медиафайлы контента (1:М, только просмотр)";
            //
            // mediaFileDataGridView
            //
            this.mediaFileDataGridView.AllowUserToAddRows = false;
            this.mediaFileDataGridView.AutoGenerateColumns = false;
            this.mediaFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaFileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mediaFileIdColumn,
            this.mediaFileTypeColumn,
            this.mediaFileQualityColumn,
            this.mediaFileSizeMbColumn,
            this.mediaFilePathColumn});
            this.mediaFileDataGridView.DataSource = this.mediaFileLinkBindingSource;
            this.mediaFileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaFileDataGridView.Location = new System.Drawing.Point(3, 16);
            this.mediaFileDataGridView.Name = "mediaFileDataGridView";
            this.mediaFileDataGridView.ReadOnly = true;
            this.mediaFileDataGridView.Size = new System.Drawing.Size(730, 127);
            this.mediaFileDataGridView.TabIndex = 0;
            //
            // mediaFileIdColumn
            //
            this.mediaFileIdColumn.DataPropertyName = "ID_файла";
            this.mediaFileIdColumn.HeaderText = "ID_файла";
            this.mediaFileIdColumn.Name = "mediaFileIdColumn";
            this.mediaFileIdColumn.Width = 70;
            //
            // mediaFileTypeColumn
            //
            this.mediaFileTypeColumn.DataPropertyName = "тип_файла";
            this.mediaFileTypeColumn.HeaderText = "Тип";
            this.mediaFileTypeColumn.Name = "mediaFileTypeColumn";
            this.mediaFileTypeColumn.Width = 70;
            //
            // mediaFileQualityColumn
            //
            this.mediaFileQualityColumn.DataPropertyName = "качество";
            this.mediaFileQualityColumn.HeaderText = "Качество";
            this.mediaFileQualityColumn.Name = "mediaFileQualityColumn";
            this.mediaFileQualityColumn.Width = 80;
            //
            // mediaFileSizeMbColumn
            //
            this.mediaFileSizeMbColumn.DataPropertyName = "Размер_МБ";
            this.mediaFileSizeMbColumn.HeaderText = "Размер, МБ";
            this.mediaFileSizeMbColumn.Name = "mediaFileSizeMbColumn";
            this.mediaFileSizeMbColumn.DefaultCellStyle.Format = "N2";
            this.mediaFileSizeMbColumn.Width = 90;
            //
            // mediaFilePathColumn
            //
            this.mediaFilePathColumn.DataPropertyName = "путь";
            this.mediaFilePathColumn.HeaderText = "Путь";
            this.mediaFilePathColumn.Name = "mediaFilePathColumn";
            this.mediaFilePathColumn.Width = 260;
            //
            // ContentDetailsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 496);
            this.Controls.Add(this.mediaFilesGroupBox);
            this.Controls.Add(this.genresGroupBox);
            this.Controls.Add(this.contentTypeComboBox);
            this.Controls.Add(this.contentTypeLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.fullTitleLabel);
            this.Controls.Add(this.fullTitleCaptionLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.contentBindingNavigator);
            this.Name = "ContentDetailsForm";
            this.Text = "Контент";
            this.Load += new System.EventHandler(this.ContentDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreLinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileLinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingNavigator)).EndInit();
            this.contentBindingNavigator.ResumeLayout(false);
            this.contentBindingNavigator.PerformLayout();
            this.genresGroupBox.ResumeLayout(false);
            this.genresGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreLinkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreLinkBindingNavigator)).EndInit();
            this.genreLinkBindingNavigator.ResumeLayout(false);
            this.genreLinkBindingNavigator.PerformLayout();
            this.mediaFilesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaFileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoHostingDBDataSet videoHostingDBDataSet;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private VideoHostingDBDataSetTableAdapters.КонтентTableAdapter contentTableAdapter;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private VideoHostingDBDataSetTableAdapters.ЖанрTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource genreLinkBindingSource;
        private VideoHostingDBDataSetTableAdapters.Контент_ЖанрTableAdapter contentGenreTableAdapter;
        private System.Windows.Forms.BindingSource mediaFileLinkBindingSource;
        private VideoHostingDBDataSetTableAdapters.Медиа_файлTableAdapter mediaFileTableAdapter;
        private VideoHostingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contentBindingNavigatorSaveItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label fullTitleCaptionLabel;
        private System.Windows.Forms.Label fullTitleLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.Label contentTypeLabel;
        private System.Windows.Forms.ComboBox contentTypeComboBox;
        private System.Windows.Forms.GroupBox genresGroupBox;
        private System.Windows.Forms.DataGridView genreLinkDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreLinkContentIdColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn genreLinkGenreIdColumn;
        private System.Windows.Forms.BindingNavigator genreLinkBindingNavigator;
        private System.Windows.Forms.ToolStripButton genreLinkAddNewButton;
        private System.Windows.Forms.ToolStripButton genreLinkDeleteButton;
        private System.Windows.Forms.ToolStripButton genreLinkSaveButton;
        private System.Windows.Forms.GroupBox mediaFilesGroupBox;
        private System.Windows.Forms.DataGridView mediaFileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaFileIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaFileTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaFileQualityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaFileSizeMbColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaFilePathColumn;
    }
}
