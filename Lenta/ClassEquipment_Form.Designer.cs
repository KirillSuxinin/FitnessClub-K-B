namespace FitnessClub.Lenta
{
    partial class ClassEquipment_Form
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
            System.Windows.Forms.Label classEquipmentIDLabel;
            System.Windows.Forms.Label classIDLabel;
            System.Windows.Forms.Label equipmentIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassEquipment_Form));
            this.fitnessClubDataSet = new FitnessClub.FitnessClubDataSet();
            this.classEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classEquipmentTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClassEquipmentTableAdapter();
            this.tableAdapterManager = new FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager();
            this.classEquipmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.classEquipmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.classEquipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.classIDComboBox = new System.Windows.Forms.ComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentIDComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.gB_about = new System.Windows.Forms.GroupBox();
            this.cb_trainer = new System.Windows.Forms.ComboBox();
            this.trainersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_classes_dayofweek = new System.Windows.Forms.TextBox();
            this.txt_trainer_surname = new System.Windows.Forms.TextBox();
            this.txt_trainer_name = new System.Windows.Forms.TextBox();
            this.txt_classes_description = new System.Windows.Forms.TextBox();
            this.txt_classes_end = new System.Windows.Forms.TextBox();
            this.txt_classes_start = new System.Windows.Forms.TextBox();
            this.txt_classes_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_equipment_type = new System.Windows.Forms.TextBox();
            this.txt_equipment_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.classesTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClassesTableAdapter();
            this.equipmentTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.EquipmentTableAdapter();
            this.trainersTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.TrainersTableAdapter();
            this.btnSortWith = new System.Windows.Forms.Button();
            classEquipmentIDLabel = new System.Windows.Forms.Label();
            classIDLabel = new System.Windows.Forms.Label();
            equipmentIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classEquipmentBindingNavigator)).BeginInit();
            this.classEquipmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.gB_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classEquipmentIDLabel
            // 
            classEquipmentIDLabel.AutoSize = true;
            classEquipmentIDLabel.Location = new System.Drawing.Point(16, 41);
            classEquipmentIDLabel.Name = "classEquipmentIDLabel";
            classEquipmentIDLabel.Size = new System.Drawing.Size(102, 13);
            classEquipmentIDLabel.TabIndex = 1;
            classEquipmentIDLabel.Text = "Class Equipment ID:";
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Location = new System.Drawing.Point(273, 41);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new System.Drawing.Size(49, 13);
            classIDLabel.TabIndex = 3;
            classIDLabel.Text = "Class ID:";
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(16, 67);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(74, 13);
            equipmentIDLabel.TabIndex = 5;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // fitnessClubDataSet
            // 
            this.fitnessClubDataSet.DataSetName = "FitnessClubDataSet";
            this.fitnessClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.fitnessClubDataSet.MergeFailed += new System.Data.MergeFailedEventHandler(this.fitnessClubDataSet_MergeFailed);
            // 
            // classEquipmentBindingSource
            // 
            this.classEquipmentBindingSource.DataMember = "ClassEquipment";
            this.classEquipmentBindingSource.DataSource = this.fitnessClubDataSet;
            this.classEquipmentBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.classEquipmentBindingSource_DataError);
            // 
            // classEquipmentTableAdapter
            // 
            this.classEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassEquipmentTableAdapter = this.classEquipmentTableAdapter;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.ClassSchedulesTableAdapter = null;
            this.tableAdapterManager.ClientClassRegistrationsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.MembershipsTableAdapter = null;
            this.tableAdapterManager.MembershipTypesTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // classEquipmentBindingNavigator
            // 
            this.classEquipmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.classEquipmentBindingNavigator.BackColor = System.Drawing.Color.Red;
            this.classEquipmentBindingNavigator.BindingSource = this.classEquipmentBindingSource;
            this.classEquipmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.classEquipmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.classEquipmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.classEquipmentBindingNavigatorSaveItem});
            this.classEquipmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.classEquipmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.classEquipmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.classEquipmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.classEquipmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.classEquipmentBindingNavigator.Name = "classEquipmentBindingNavigator";
            this.classEquipmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.classEquipmentBindingNavigator.Size = new System.Drawing.Size(637, 25);
            this.classEquipmentBindingNavigator.TabIndex = 0;
            this.classEquipmentBindingNavigator.Tag = "ONLY_ADMIN";
            this.classEquipmentBindingNavigator.Text = "bindingNavigator1";
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
            // classEquipmentBindingNavigatorSaveItem
            // 
            this.classEquipmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.classEquipmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("classEquipmentBindingNavigatorSaveItem.Image")));
            this.classEquipmentBindingNavigatorSaveItem.Name = "classEquipmentBindingNavigatorSaveItem";
            this.classEquipmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.classEquipmentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.classEquipmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.classEquipmentBindingNavigatorSaveItem_Click);
            // 
            // classEquipmentIDTextBox
            // 
            this.classEquipmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classEquipmentBindingSource, "ClassEquipmentID", true));
            this.classEquipmentIDTextBox.Location = new System.Drawing.Point(146, 38);
            this.classEquipmentIDTextBox.Name = "classEquipmentIDTextBox";
            this.classEquipmentIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.classEquipmentIDTextBox.TabIndex = 2;
            // 
            // classIDComboBox
            // 
            this.classIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classEquipmentBindingSource, "ClassID", true));
            this.classIDComboBox.DataSource = this.classesBindingSource;
            this.classIDComboBox.DisplayMember = "ClassID";
            this.classIDComboBox.FormattingEnabled = true;
            this.classIDComboBox.Location = new System.Drawing.Point(355, 37);
            this.classIDComboBox.Name = "classIDComboBox";
            this.classIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.classIDComboBox.TabIndex = 4;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // equipmentIDComboBox
            // 
            this.equipmentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classEquipmentBindingSource, "EquipmentID", true));
            this.equipmentIDComboBox.DataSource = this.equipmentBindingSource;
            this.equipmentIDComboBox.DisplayMember = "EquipmentID";
            this.equipmentIDComboBox.FormattingEnabled = true;
            this.equipmentIDComboBox.Location = new System.Drawing.Point(146, 64);
            this.equipmentIDComboBox.Name = "equipmentIDComboBox";
            this.equipmentIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.equipmentIDComboBox.TabIndex = 6;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // btn_last
            // 
            this.btn_last.AccessibleName = "NONESTYLE";
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Location = new System.Drawing.Point(532, 299);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(92, 23);
            this.btn_last.TabIndex = 25;
            this.btn_last.Text = "Посл. запись";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.AccessibleName = "NONESTYLE";
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(434, 299);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(92, 23);
            this.btn_Next.TabIndex = 26;
            this.btn_Next.Text = "След. запись";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AccessibleName = "NONESTYLE";
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(116, 299);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(92, 23);
            this.btnPrev.TabIndex = 27;
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
            this.btnCancel.Location = new System.Drawing.Point(244, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Отменить изменения";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.AccessibleName = "NONESTYLE";
            this.btnSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorting.Location = new System.Drawing.Point(116, 345);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(111, 23);
            this.btnSorting.TabIndex = 29;
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
            this.btnDelete.Location = new System.Drawing.Point(336, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 30;
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
            this.btnAdd.Location = new System.Drawing.Point(434, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 31;
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
            this.btnSave.Location = new System.Drawing.Point(532, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "NONESTYLE";
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(18, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 23);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.AccessibleName = "NONESTYLE";
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(18, 299);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(92, 23);
            this.btnFirst.TabIndex = 34;
            this.btnFirst.Text = "Перв. запись";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // gB_about
            // 
            this.gB_about.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_about.Controls.Add(this.cb_trainer);
            this.gB_about.Controls.Add(this.txt_classes_dayofweek);
            this.gB_about.Controls.Add(this.txt_trainer_surname);
            this.gB_about.Controls.Add(this.txt_trainer_name);
            this.gB_about.Controls.Add(this.txt_classes_description);
            this.gB_about.Controls.Add(this.txt_classes_end);
            this.gB_about.Controls.Add(this.txt_classes_start);
            this.gB_about.Controls.Add(this.txt_classes_name);
            this.gB_about.Controls.Add(this.label5);
            this.gB_about.Controls.Add(this.label6);
            this.gB_about.Controls.Add(this.label4);
            this.gB_about.Controls.Add(this.label3);
            this.gB_about.Controls.Add(this.label2);
            this.gB_about.Controls.Add(this.label1);
            this.gB_about.Location = new System.Drawing.Point(19, 128);
            this.gB_about.Name = "gB_about";
            this.gB_about.Size = new System.Drawing.Size(605, 165);
            this.gB_about.TabIndex = 35;
            this.gB_about.TabStop = false;
            this.gB_about.Text = "О классе";
            // 
            // cb_trainer
            // 
            this.cb_trainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.cb_trainer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "TrainerID", true));
            this.cb_trainer.DataSource = this.trainersBindingSource;
            this.cb_trainer.DisplayMember = "TrainerID";
            this.cb_trainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trainer.Enabled = false;
            this.cb_trainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_trainer.FormattingEnabled = true;
            this.cb_trainer.Location = new System.Drawing.Point(97, 62);
            this.cb_trainer.Name = "cb_trainer";
            this.cb_trainer.Size = new System.Drawing.Size(40, 21);
            this.cb_trainer.TabIndex = 36;
            // 
            // trainersBindingSource
            // 
            this.trainersBindingSource.DataMember = "Trainers";
            this.trainersBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // txt_classes_dayofweek
            // 
            this.txt_classes_dayofweek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txt_classes_dayofweek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_classes_dayofweek.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "DayOfWeek", true));
            this.txt_classes_dayofweek.Location = new System.Drawing.Point(97, 119);
            this.txt_classes_dayofweek.Name = "txt_classes_dayofweek";
            this.txt_classes_dayofweek.ReadOnly = true;
            this.txt_classes_dayofweek.Size = new System.Drawing.Size(440, 13);
            this.txt_classes_dayofweek.TabIndex = 4;
            // 
            // txt_trainer_surname
            // 
            this.txt_trainer_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txt_trainer_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_trainer_surname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "LastName", true));
            this.txt_trainer_surname.Location = new System.Drawing.Point(214, 65);
            this.txt_trainer_surname.Name = "txt_trainer_surname";
            this.txt_trainer_surname.ReadOnly = true;
            this.txt_trainer_surname.Size = new System.Drawing.Size(77, 13);
            this.txt_trainer_surname.TabIndex = 4;
            // 
            // txt_trainer_name
            // 
            this.txt_trainer_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txt_trainer_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_trainer_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainersBindingSource, "FirstName", true));
            this.txt_trainer_name.Location = new System.Drawing.Point(143, 65);
            this.txt_trainer_name.Name = "txt_trainer_name";
            this.txt_trainer_name.ReadOnly = true;
            this.txt_trainer_name.Size = new System.Drawing.Size(65, 13);
            this.txt_trainer_name.TabIndex = 4;
            // 
            // txt_classes_description
            // 
            this.txt_classes_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txt_classes_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_classes_description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Description", true));
            this.txt_classes_description.Location = new System.Drawing.Point(97, 39);
            this.txt_classes_description.Name = "txt_classes_description";
            this.txt_classes_description.ReadOnly = true;
            this.txt_classes_description.Size = new System.Drawing.Size(440, 13);
            this.txt_classes_description.TabIndex = 3;
            // 
            // txt_classes_end
            // 
            this.txt_classes_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txt_classes_end.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_classes_end.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "EndTime", true));
            this.txt_classes_end.Location = new System.Drawing.Point(180, 89);
            this.txt_classes_end.Name = "txt_classes_end";
            this.txt_classes_end.ReadOnly = true;
            this.txt_classes_end.Size = new System.Drawing.Size(65, 13);
            this.txt_classes_end.TabIndex = 2;
            // 
            // txt_classes_start
            // 
            this.txt_classes_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txt_classes_start.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_classes_start.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "StartTime", true));
            this.txt_classes_start.Location = new System.Drawing.Point(97, 89);
            this.txt_classes_start.Name = "txt_classes_start";
            this.txt_classes_start.ReadOnly = true;
            this.txt_classes_start.Size = new System.Drawing.Size(65, 13);
            this.txt_classes_start.TabIndex = 2;
            // 
            // txt_classes_name
            // 
            this.txt_classes_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txt_classes_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_classes_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "Name", true));
            this.txt_classes_name.Location = new System.Drawing.Point(97, 17);
            this.txt_classes_name.Name = "txt_classes_name";
            this.txt_classes_name.ReadOnly = true;
            this.txt_classes_name.Size = new System.Drawing.Size(440, 13);
            this.txt_classes_name.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "День недели -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Начало -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Тренер -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Тип оборудования -";
            // 
            // txt_equipment_type
            // 
            this.txt_equipment_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txt_equipment_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_equipment_type.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Type", true));
            this.txt_equipment_type.Location = new System.Drawing.Point(381, 93);
            this.txt_equipment_type.Name = "txt_equipment_type";
            this.txt_equipment_type.ReadOnly = true;
            this.txt_equipment_type.Size = new System.Drawing.Size(233, 13);
            this.txt_equipment_type.TabIndex = 4;
            // 
            // txt_equipment_name
            // 
            this.txt_equipment_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.txt_equipment_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_equipment_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Name", true));
            this.txt_equipment_name.Location = new System.Drawing.Point(364, 67);
            this.txt_equipment_name.Name = "txt_equipment_name";
            this.txt_equipment_name.ReadOnly = true;
            this.txt_equipment_name.Size = new System.Drawing.Size(233, 13);
            this.txt_equipment_name.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Наименование -";
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // trainersTableAdapter
            // 
            this.trainersTableAdapter.ClearBeforeFill = true;
            // 
            // btnSortWith
            // 
            this.btnSortWith.AccessibleName = "NONESTYLE";
            this.btnSortWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSortWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortWith.Location = new System.Drawing.Point(233, 345);
            this.btnSortWith.Name = "btnSortWith";
            this.btnSortWith.Size = new System.Drawing.Size(97, 23);
            this.btnSortWith.TabIndex = 29;
            this.btnSortWith.Text = "Сорт. с под.";
            this.btnSortWith.UseVisualStyleBackColor = true;
            this.btnSortWith.Click += new System.EventHandler(this.btnSortWith_Click);
            // 
            // ClassEquipment_Form
            // 
            this.AccessibleDescription = "ClassEquipment";
            this.AccessibleName = "FORM_TRANSLATE";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(637, 385);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_equipment_type);
            this.Controls.Add(this.gB_about);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.txt_equipment_name);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSortWith);
            this.Controls.Add(this.btnSorting);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(classEquipmentIDLabel);
            this.Controls.Add(this.classEquipmentIDTextBox);
            this.Controls.Add(classIDLabel);
            this.Controls.Add(this.classIDComboBox);
            this.Controls.Add(equipmentIDLabel);
            this.Controls.Add(this.equipmentIDComboBox);
            this.Controls.Add(this.classEquipmentBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(653, 424);
            this.Name = "ClassEquipment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SAVE_SIZE";
            this.Text = "Оборудование классов";
            this.Load += new System.EventHandler(this.ClassEquipment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classEquipmentBindingNavigator)).EndInit();
            this.classEquipmentBindingNavigator.ResumeLayout(false);
            this.classEquipmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.gB_about.ResumeLayout(false);
            this.gB_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FitnessClubDataSet fitnessClubDataSet;
        private System.Windows.Forms.BindingSource classEquipmentBindingSource;
        private FitnessClubDataSetTableAdapters.ClassEquipmentTableAdapter classEquipmentTableAdapter;
        private FitnessClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator classEquipmentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton classEquipmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox classEquipmentIDTextBox;
        private System.Windows.Forms.ComboBox classIDComboBox;
        private System.Windows.Forms.ComboBox equipmentIDComboBox;
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
        private System.Windows.Forms.GroupBox gB_about;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private FitnessClubDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private FitnessClubDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_classes_name;
        private System.Windows.Forms.TextBox txt_classes_description;
        private System.Windows.Forms.TextBox txt_trainer_surname;
        private System.Windows.Forms.TextBox txt_trainer_name;
        private System.Windows.Forms.ComboBox cb_trainer;
        private FitnessClubDataSetTableAdapters.TrainersTableAdapter trainersTableAdapter;
        private System.Windows.Forms.BindingSource trainersBindingSource;
        private System.Windows.Forms.TextBox txt_classes_start;
        private System.Windows.Forms.TextBox txt_classes_end;
        private System.Windows.Forms.TextBox txt_classes_dayofweek;
        private System.Windows.Forms.TextBox txt_equipment_type;
        private System.Windows.Forms.TextBox txt_equipment_name;
        private System.Windows.Forms.Button btnSortWith;
    }
}