namespace VideoHostingApp
{
    partial class ContentListForm
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
            System.Windows.Forms.Label contentIdLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label originalTitleLabel;
            System.Windows.Forms.Label releaseYearLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label ageRatingLabel;
            System.Windows.Forms.Label contentTypeLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label addedDateLabel;
            System.Windows.Forms.Label posterLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentListForm));
            this.videoHostingDBDataSet = new VideoHostingApp.VideoHostingDBDataSet();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentTableAdapter = new VideoHostingApp.VideoHostingDBDataSetTableAdapters.КонтентTableAdapter();
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
            this.contentIdTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.originalTitleTextBox = new System.Windows.Forms.TextBox();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.durationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.ageRatingComboBox = new System.Windows.Forms.ComboBox();
            this.contentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.openPhotoButton = new System.Windows.Forms.Button();
            this.photoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            contentIdLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            originalTitleLabel = new System.Windows.Forms.Label();
            releaseYearLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ageRatingLabel = new System.Windows.Forms.Label();
            contentTypeLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            addedDateLabel = new System.Windows.Forms.Label();
            posterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingNavigator)).BeginInit();
            this.contentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contentIdLabel
            // 
            contentIdLabel.AutoSize = true;
            contentIdLabel.Location = new System.Drawing.Point(12, 35);
            contentIdLabel.Name = "contentIdLabel";
            contentIdLabel.Size = new System.Drawing.Size(70, 13);
            contentIdLabel.TabIndex = 1;
            contentIdLabel.Text = "ID контента:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 61);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(58, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "название:";
            // 
            // originalTitleLabel
            // 
            originalTitleLabel.AutoSize = true;
            originalTitleLabel.Location = new System.Drawing.Point(12, 87);
            originalTitleLabel.Name = "originalTitleLabel";
            originalTitleLabel.Size = new System.Drawing.Size(132, 13);
            originalTitleLabel.TabIndex = 5;
            originalTitleLabel.Text = "оригинальное название:";
            // 
            // releaseYearLabel
            // 
            releaseYearLabel.AutoSize = true;
            releaseYearLabel.Location = new System.Drawing.Point(12, 113);
            releaseYearLabel.Name = "releaseYearLabel";
            releaseYearLabel.Size = new System.Drawing.Size(73, 13);
            releaseYearLabel.TabIndex = 7;
            releaseYearLabel.Text = "год выпуска:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(12, 139);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(119, 13);
            countryLabel.TabIndex = 9;
            countryLabel.Text = "страна производства:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(12, 165);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(60, 13);
            directorLabel.TabIndex = 11;
            directorLabel.Text = "режиссёр:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 191);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(102, 13);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "краткое описание:";
            // 
            // ageRatingLabel
            // 
            ageRatingLabel.AutoSize = true;
            ageRatingLabel.Location = new System.Drawing.Point(12, 217);
            ageRatingLabel.Name = "ageRatingLabel";
            ageRatingLabel.Size = new System.Drawing.Size(112, 13);
            ageRatingLabel.TabIndex = 15;
            ageRatingLabel.Text = "возрастной рейтинг:";
            // 
            // contentTypeLabel
            // 
            contentTypeLabel.AutoSize = true;
            contentTypeLabel.Location = new System.Drawing.Point(12, 243);
            contentTypeLabel.Name = "contentTypeLabel";
            contentTypeLabel.Size = new System.Drawing.Size(76, 13);
            contentTypeLabel.TabIndex = 17;
            contentTypeLabel.Text = "тип контента:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(12, 269);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(80, 13);
            durationLabel.TabIndex = 19;
            durationLabel.Text = "длительность:";
            // 
            // addedDateLabel
            // 
            addedDateLabel.AutoSize = true;
            addedDateLabel.Location = new System.Drawing.Point(12, 296);
            addedDateLabel.Name = "addedDateLabel";
            addedDateLabel.Size = new System.Drawing.Size(100, 13);
            addedDateLabel.TabIndex = 21;
            addedDateLabel.Text = "дата поступления:";
            // 
            // posterLabel
            // 
            posterLabel.AutoSize = true;
            posterLabel.Location = new System.Drawing.Point(356, 35);
            posterLabel.Name = "posterLabel";
            posterLabel.Size = new System.Drawing.Size(45, 13);
            posterLabel.TabIndex = 23;
            posterLabel.Text = "постер:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = VideoHostingApp.VideoHostingDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговорTableAdapter = null;
            this.tableAdapterManager.ЖанрTableAdapter = null;
            this.tableAdapterManager.Контент_ЖанрTableAdapter = null;
            this.tableAdapterManager.КонтентTableAdapter = this.contentTableAdapter;
            this.tableAdapterManager.ЛицензияTableAdapter = null;
            this.tableAdapterManager.Медиа_файлTableAdapter = null;
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
            this.contentBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.contentBindingNavigator.TabIndex = 0;
            this.contentBindingNavigator.Text = "bindingNavigator1";
            this.contentBindingNavigator.Click += new System.EventHandler(this.ContentBindingNavigatorSaveItem_Click);
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
            // contentBindingNavigatorSaveItem
            // 
            this.contentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contentBindingNavigatorSaveItem.Image")));
            this.contentBindingNavigatorSaveItem.Name = "contentBindingNavigatorSaveItem";
            this.contentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.contentBindingNavigatorSaveItem.Click += new System.EventHandler(this.ContentBindingNavigatorSaveItem_Click);
            // 
            // contentIdTextBox
            // 
            this.contentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "ID_контента", true));
            this.contentIdTextBox.Location = new System.Drawing.Point(150, 32);
            this.contentIdTextBox.Name = "contentIdTextBox";
            this.contentIdTextBox.ReadOnly = true;
            this.contentIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.contentIdTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "название", true));
            this.titleTextBox.Location = new System.Drawing.Point(150, 58);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // originalTitleTextBox
            // 
            this.originalTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "оригинальное_название", true));
            this.originalTitleTextBox.Location = new System.Drawing.Point(150, 84);
            this.originalTitleTextBox.Name = "originalTitleTextBox";
            this.originalTitleTextBox.Size = new System.Drawing.Size(200, 20);
            this.originalTitleTextBox.TabIndex = 6;
            // 
            // releaseYearTextBox
            // 
            this.releaseYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "год_выпуска", true));
            this.releaseYearTextBox.Location = new System.Drawing.Point(150, 110);
            this.releaseYearTextBox.Name = "releaseYearTextBox";
            this.releaseYearTextBox.Size = new System.Drawing.Size(200, 20);
            this.releaseYearTextBox.TabIndex = 8;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "страна_производства", true));
            this.countryTextBox.Location = new System.Drawing.Point(150, 136);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryTextBox.TabIndex = 10;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "режиссёр", true));
            this.directorTextBox.Location = new System.Drawing.Point(150, 162);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(200, 20);
            this.directorTextBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "краткое_описание", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(150, 188);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // durationMaskedTextBox
            // 
            this.durationMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "длительность", true));
            this.durationMaskedTextBox.Location = new System.Drawing.Point(150, 266);
            this.durationMaskedTextBox.Mask = "00:00:00";
            this.durationMaskedTextBox.Name = "durationMaskedTextBox";
            this.durationMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.durationMaskedTextBox.TabIndex = 20;
            // 
            // addedDateTimePicker
            // 
            this.addedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contentBindingSource, "дата_поступления", true));
            this.addedDateTimePicker.Location = new System.Drawing.Point(150, 292);
            this.addedDateTimePicker.Name = "addedDateTimePicker";
            this.addedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.addedDateTimePicker.TabIndex = 22;
            // 
            // posterPictureBox
            // 
            this.posterPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.contentBindingSource, "постер", true));
            this.posterPictureBox.Location = new System.Drawing.Point(440, 32);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(200, 350);
            this.posterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.posterPictureBox.TabIndex = 24;
            this.posterPictureBox.TabStop = false;
            // 
            // ageRatingComboBox
            // 
            this.ageRatingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "возрастной_рейтинг", true));
            this.ageRatingComboBox.FormattingEnabled = true;
            this.ageRatingComboBox.Location = new System.Drawing.Point(150, 214);
            this.ageRatingComboBox.Name = "ageRatingComboBox";
            this.ageRatingComboBox.Size = new System.Drawing.Size(200, 21);
            this.ageRatingComboBox.TabIndex = 25;
            // 
            // contentTypeComboBox
            // 
            this.contentTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contentBindingSource, "тип_контента", true));
            this.contentTypeComboBox.FormattingEnabled = true;
            this.contentTypeComboBox.Items.AddRange(new object[] {
            "Фильм, Мультфильм, Сериал, Мультсериал, Короткометражный фильм, Трейлер"});
            this.contentTypeComboBox.Location = new System.Drawing.Point(150, 240);
            this.contentTypeComboBox.Name = "contentTypeComboBox";
            this.contentTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.contentTypeComboBox.TabIndex = 26;
            // 
            // openPhotoButton
            // 
            this.openPhotoButton.Location = new System.Drawing.Point(356, 58);
            this.openPhotoButton.Name = "openPhotoButton";
            this.openPhotoButton.Size = new System.Drawing.Size(75, 46);
            this.openPhotoButton.TabIndex = 27;
            this.openPhotoButton.Text = "Открыть постер";
            this.openPhotoButton.UseVisualStyleBackColor = true;
            this.openPhotoButton.Click += new System.EventHandler(this.openPhotoButton_Click);
            // 
            // photoOpenFileDialog
            // 
            this.photoOpenFileDialog.FileName = "openFileDialog1";
            this.photoOpenFileDialog.Filter = "\"Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif\"";
            this.photoOpenFileDialog.RestoreDirectory = true;
            this.photoOpenFileDialog.Title = "\"Выберите файл постера\"";
            // 
            // ContentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.openPhotoButton);
            this.Controls.Add(this.contentTypeComboBox);
            this.Controls.Add(this.ageRatingComboBox);
            this.Controls.Add(contentIdLabel);
            this.Controls.Add(this.contentIdTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(originalTitleLabel);
            this.Controls.Add(this.originalTitleTextBox);
            this.Controls.Add(releaseYearLabel);
            this.Controls.Add(this.releaseYearTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(ageRatingLabel);
            this.Controls.Add(contentTypeLabel);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationMaskedTextBox);
            this.Controls.Add(addedDateLabel);
            this.Controls.Add(this.addedDateTimePicker);
            this.Controls.Add(posterLabel);
            this.Controls.Add(this.posterPictureBox);
            this.Controls.Add(this.contentBindingNavigator);
            this.Name = "ContentListForm";
            this.Text = "ContentListForm";
            this.Load += new System.EventHandler(this.ContentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoHostingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingNavigator)).EndInit();
            this.contentBindingNavigator.ResumeLayout(false);
            this.contentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoHostingDBDataSet videoHostingDBDataSet;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private VideoHostingDBDataSetTableAdapters.КонтентTableAdapter contentTableAdapter;
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
        private System.Windows.Forms.TextBox contentIdTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox originalTitleTextBox;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.MaskedTextBox durationMaskedTextBox;
        private System.Windows.Forms.DateTimePicker addedDateTimePicker;
        private System.Windows.Forms.PictureBox posterPictureBox;
        private System.Windows.Forms.ComboBox ageRatingComboBox;
        private System.Windows.Forms.ComboBox contentTypeComboBox;
        private System.Windows.Forms.Button openPhotoButton;
        private System.Windows.Forms.OpenFileDialog photoOpenFileDialog;
    }
}