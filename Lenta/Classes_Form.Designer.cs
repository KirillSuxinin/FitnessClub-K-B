namespace FitnessClub.Lenta
{
    partial class Classes_Form
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
            System.Windows.Forms.Label classIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label trainerIDLabel;
            System.Windows.Forms.Label maxCapacityLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label dayOfWeekLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classes_Form));
            this.fitnessClubDataSet = new FitnessClub.FitnessClubDataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClassesTableAdapter();
            this.tableAdapterManager = new FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager();
            this.trainersTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.TrainersTableAdapter();
            this.classesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.classesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.classIDComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.trainerIDComboBox = new System.Windows.Forms.ComboBox();
            this.trainersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maxCapacityTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.dayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSorting = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btn_registrationOnClasses = new System.Windows.Forms.Button();
            classIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            trainerIDLabel = new System.Windows.Forms.Label();
            maxCapacityLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            dayOfWeekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingNavigator)).BeginInit();
            this.classesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Location = new System.Drawing.Point(8, 34);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new System.Drawing.Size(49, 13);
            classIDLabel.TabIndex = 1;
            classIDLabel.Text = "Class ID:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(352, 38);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(352, 64);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // trainerIDLabel
            // 
            trainerIDLabel.AutoSize = true;
            trainerIDLabel.Location = new System.Drawing.Point(8, 61);
            trainerIDLabel.Name = "trainerIDLabel";
            trainerIDLabel.Size = new System.Drawing.Size(57, 13);
            trainerIDLabel.TabIndex = 7;
            trainerIDLabel.Text = "Trainer ID:";
            // 
            // maxCapacityLabel
            // 
            maxCapacityLabel.AutoSize = true;
            maxCapacityLabel.Location = new System.Drawing.Point(8, 88);
            maxCapacityLabel.Name = "maxCapacityLabel";
            maxCapacityLabel.Size = new System.Drawing.Size(74, 13);
            maxCapacityLabel.TabIndex = 9;
            maxCapacityLabel.Text = "Max Capacity:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(8, 114);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 11;
            startTimeLabel.Text = "Start Time:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(352, 117);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 13;
            endTimeLabel.Text = "End Time:";
            // 
            // dayOfWeekLabel
            // 
            dayOfWeekLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dayOfWeekLabel.AutoSize = true;
            dayOfWeekLabel.Location = new System.Drawing.Point(352, 91);
            dayOfWeekLabel.Name = "dayOfWeekLabel";
            dayOfWeekLabel.Size = new System.Drawing.Size(75, 13);
            dayOfWeekLabel.TabIndex = 15;
            dayOfWeekLabel.Text = "Day Of Week:";
            // 
            // fitnessClubDataSet
            // 
            this.fitnessClubDataSet.DataSetName = "FitnessClubDataSet";
            this.fitnessClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassEquipmentTableAdapter = null;
            this.tableAdapterManager.ClassesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager.ClassSchedulesTableAdapter = null;
            this.tableAdapterManager.ClientClassRegistrationsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.MembershipsTableAdapter = null;
            this.tableAdapterManager.MembershipTypesTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = this.trainersTableAdapter;
            this.tableAdapterManager.UpdateOrder = FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // trainersTableAdapter
            // 
            this.trainersTableAdapter.ClearBeforeFill = true;
            // 
            // classesBindingNavigator
            // 
            this.classesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.classesBindingNavigator.BackColor = System.Drawing.Color.Red;
            this.classesBindingNavigator.BindingSource = this.classesBindingSource;
            this.classesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.classesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.classesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.classesBindingNavigatorSaveItem});
            this.classesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.classesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.classesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.classesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.classesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.classesBindingNavigator.Name = "classesBindingNavigator";
            this.classesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.classesBindingNavigator.Size = new System.Drawing.Size(645, 25);
            this.classesBindingNavigator.TabIndex = 0;
            this.classesBindingNavigator.Tag = "ONLY_ADMIN";
            this.classesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.Red;
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
            // classesBindingNavigatorSaveItem
            // 
            this.classesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.classesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("classesBindingNavigatorSaveItem.Image")));
            this.classesBindingNavigatorSaveItem.Name = "classesBindingNavigatorSaveItem";
            this.classesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.classesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.classesBindingNavigatorSaveItem.Click += new System.EventHandler(this.classesBindingNavigatorSaveItem_Click);
            // 
            // classIDComboBox
            // 
            this.classIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "ClassID", true));
            this.classIDComboBox.FormattingEnabled = true;
            this.classIDComboBox.Location = new System.Drawing.Point(133, 32);
            this.classIDComboBox.Name = "classIDComboBox";
            this.classIDComboBox.Size = new System.Drawing.Size(134, 21);
            this.classIDComboBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(444, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(189, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(444, 61);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(189, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // trainerIDComboBox
            // 
            this.trainerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "TrainerID", true));
            this.trainerIDComboBox.DataSource = this.trainersBindingSource;
            this.trainerIDComboBox.DisplayMember = "TrainerID";
            this.trainerIDComboBox.FormattingEnabled = true;
            this.trainerIDComboBox.Location = new System.Drawing.Point(133, 59);
            this.trainerIDComboBox.Name = "trainerIDComboBox";
            this.trainerIDComboBox.Size = new System.Drawing.Size(37, 21);
            this.trainerIDComboBox.TabIndex = 8;
            // 
            // trainersBindingSource
            // 
            this.trainersBindingSource.DataMember = "Trainers";
            this.trainersBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // maxCapacityTextBox
            // 
            this.maxCapacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "MaxCapacity", true));
            this.maxCapacityTextBox.Location = new System.Drawing.Point(133, 86);
            this.maxCapacityTextBox.Name = "maxCapacityTextBox";
            this.maxCapacityTextBox.Size = new System.Drawing.Size(134, 20);
            this.maxCapacityTextBox.TabIndex = 10;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "StartTime", true));
            this.startTimeTextBox.Location = new System.Drawing.Point(133, 112);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(134, 20);
            this.startTimeTextBox.TabIndex = 12;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "EndTime", true));
            this.endTimeTextBox.Location = new System.Drawing.Point(444, 114);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(189, 20);
            this.endTimeTextBox.TabIndex = 14;
            // 
            // dayOfWeekComboBox
            // 
            this.dayOfWeekComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayOfWeekComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "DayOfWeek", true));
            this.dayOfWeekComboBox.FormattingEnabled = true;
            this.dayOfWeekComboBox.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.dayOfWeekComboBox.Location = new System.Drawing.Point(444, 87);
            this.dayOfWeekComboBox.Name = "dayOfWeekComboBox";
            this.dayOfWeekComboBox.Size = new System.Drawing.Size(189, 21);
            this.dayOfWeekComboBox.TabIndex = 16;
            // 
            // cmb_name
            // 
            this.cmb_name.DataSource = this.trainersBindingSource;
            this.cmb_name.DisplayMember = "FirstName";
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(176, 59);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(91, 21);
            this.cmb_name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "LastName", true));
            this.label1.Location = new System.Drawing.Point(273, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtSpecialization);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 114);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "О тренере";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(104, 88);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(151, 13);
            this.txtPhone.TabIndex = 1;
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txtSpecialization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpecialization.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "Specialization", true));
            this.txtSpecialization.Location = new System.Drawing.Point(104, 65);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.ReadOnly = true;
            this.txtSpecialization.Size = new System.Drawing.Size(151, 13);
            this.txtSpecialization.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "LastName", true));
            this.txtSurname.Location = new System.Drawing.Point(104, 39);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(151, 13);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "FirstName", true));
            this.txtName.Location = new System.Drawing.Point(104, 16);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(151, 13);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Номер -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Специализация -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фамилия -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя -";
            // 
            // btn_last
            // 
            this.btn_last.AccessibleName = "NONESTYLE";
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Location = new System.Drawing.Point(541, 258);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(92, 23);
            this.btn_last.TabIndex = 20;
            this.btn_last.Text = "Посл. запись";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.AccessibleName = "NONESTYLE";
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(443, 258);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(92, 23);
            this.btn_Next.TabIndex = 21;
            this.btn_Next.Text = "След. запись";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AccessibleName = "NONESTYLE";
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(111, 258);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(92, 23);
            this.btnPrev.TabIndex = 22;
            this.btnPrev.Text = "Пред. запись";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "ONLY_ADMIN";
            this.btnCancel.AccessibleName = "NONESTYLE";
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(253, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Отменить изменения";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.AccessibleName = "NONESTYLE";
            this.btnSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorting.Location = new System.Drawing.Point(111, 304);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(111, 23);
            this.btnSorting.TabIndex = 24;
            this.btnSorting.Text = "Сортировка";
            this.btnSorting.UseVisualStyleBackColor = true;
            this.btnSorting.Click += new System.EventHandler(this.btnSorting_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "ONLY_ADMIN";
            this.btnDelete.AccessibleName = "NONESTYLE";
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(345, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "ONLY_ADMIN";
            this.btnAdd.AccessibleName = "NONESTYLE";
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(443, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "ONLY_ADMIN";
            this.btnSave.AccessibleName = "NONESTYLE";
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(541, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "NONESTYLE";
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(13, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.AccessibleName = "NONESTYLE";
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(13, 258);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(92, 23);
            this.btnFirst.TabIndex = 29;
            this.btnFirst.Text = "Перв. запись";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btn_registrationOnClasses
            // 
            this.btn_registrationOnClasses.AccessibleDescription = "ONLY_USER";
            this.btn_registrationOnClasses.AccessibleName = "NONESTYLE";
            this.btn_registrationOnClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registrationOnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrationOnClasses.Location = new System.Drawing.Point(522, 303);
            this.btn_registrationOnClasses.Name = "btn_registrationOnClasses";
            this.btn_registrationOnClasses.Size = new System.Drawing.Size(111, 23);
            this.btn_registrationOnClasses.TabIndex = 24;
            this.btn_registrationOnClasses.Text = "Записаться";
            this.btn_registrationOnClasses.UseVisualStyleBackColor = true;
            this.btn_registrationOnClasses.Click += new System.EventHandler(this.btn_registrationOnClasses_Click);
            // 
            // Classes_Form
            // 
            this.AccessibleDescription = "Classes";
            this.AccessibleName = "FORM_TRANSLATE";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(645, 338);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSorting);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_name);
            this.Controls.Add(classIDLabel);
            this.Controls.Add(this.classIDComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(trainerIDLabel);
            this.Controls.Add(this.trainerIDComboBox);
            this.Controls.Add(maxCapacityLabel);
            this.Controls.Add(this.maxCapacityTextBox);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(this.endTimeTextBox);
            this.Controls.Add(dayOfWeekLabel);
            this.Controls.Add(this.dayOfWeekComboBox);
            this.Controls.Add(this.classesBindingNavigator);
            this.Controls.Add(this.btn_registrationOnClasses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(661, 377);
            this.Name = "Classes_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SAVE_SIZE";
            this.Text = "Занятия";
            this.Load += new System.EventHandler(this.Classes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingNavigator)).EndInit();
            this.classesBindingNavigator.ResumeLayout(false);
            this.classesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FitnessClubDataSet fitnessClubDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private FitnessClubDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private FitnessClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator classesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton classesBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox classIDComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox trainerIDComboBox;
        private System.Windows.Forms.TextBox maxCapacityTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.ComboBox dayOfWeekComboBox;
        private FitnessClubDataSetTableAdapters.TrainersTableAdapter trainersTableAdapter;
        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.BindingSource trainersBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSorting;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btn_registrationOnClasses;
    }
}