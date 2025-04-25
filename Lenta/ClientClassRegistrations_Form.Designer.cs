namespace FitnessClub.Lenta
{
    partial class ClientClassRegistrations_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientClassRegistrations_Form));
            System.Windows.Forms.Label registrationIDLabel;
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label classScheduleIDLabel;
            System.Windows.Forms.Label registeredAtLabel;
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
            this.fitnessClubDataSet = new FitnessClub.FitnessClubDataSet();
            this.clientClassRegistrationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientClassRegistrationsTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClientClassRegistrationsTableAdapter();
            this.tableAdapterManager = new FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager();
            this.clientClassRegistrationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clientClassRegistrationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.registrationIDComboBox = new System.Windows.Forms.ComboBox();
            this.clientIDComboBox = new System.Windows.Forms.ComboBox();
            this.classScheduleIDComboBox = new System.Windows.Forms.ComboBox();
            this.registeredAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClientsTableAdapter();
            this.classSchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classSchedulesTableAdapter = new FitnessClub.FitnessClubDataSetTableAdapters.ClassSchedulesTableAdapter();
            registrationIDLabel = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            classScheduleIDLabel = new System.Windows.Forms.Label();
            registeredAtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientClassRegistrationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientClassRegistrationsBindingNavigator)).BeginInit();
            this.clientClassRegistrationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSchedulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_last
            // 
            this.btn_last.AccessibleName = "NONESTYLE";
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Location = new System.Drawing.Point(518, 181);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(92, 23);
            this.btn_last.TabIndex = 40;
            this.btn_last.Text = "Посл. запись";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.AccessibleName = "NONESTYLE";
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(420, 181);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(92, 23);
            this.btn_Next.TabIndex = 41;
            this.btn_Next.Text = "След. запись";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AccessibleName = "NONESTYLE";
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(113, 181);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(92, 23);
            this.btnPrev.TabIndex = 42;
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
            this.btnCancel.Location = new System.Drawing.Point(243, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 23);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Отменить изменения";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.AccessibleName = "NONESTYLE";
            this.btnSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorting.Location = new System.Drawing.Point(113, 227);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(111, 23);
            this.btnSorting.TabIndex = 44;
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
            this.btnDelete.Location = new System.Drawing.Point(322, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 45;
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
            this.btnAdd.Location = new System.Drawing.Point(420, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 46;
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
            this.btnSave.Location = new System.Drawing.Point(518, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "NONESTYLE";
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(15, 227);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 23);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.AccessibleName = "NONESTYLE";
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(15, 181);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(92, 23);
            this.btnFirst.TabIndex = 49;
            this.btnFirst.Text = "Перв. запись";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // fitnessClubDataSet
            // 
            this.fitnessClubDataSet.DataSetName = "FitnessClubDataSet";
            this.fitnessClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientClassRegistrationsBindingSource
            // 
            this.clientClassRegistrationsBindingSource.DataMember = "ClientClassRegistrations";
            this.clientClassRegistrationsBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // clientClassRegistrationsTableAdapter
            // 
            this.clientClassRegistrationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassEquipmentTableAdapter = null;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.ClassSchedulesTableAdapter = this.classSchedulesTableAdapter;
            this.tableAdapterManager.ClientClassRegistrationsTableAdapter = this.clientClassRegistrationsTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.ImagesTableAdapter = null;
            this.tableAdapterManager.MembershipsTableAdapter = null;
            this.tableAdapterManager.MembershipTypesTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.TrainersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FitnessClub.FitnessClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // clientClassRegistrationsBindingNavigator
            // 
            this.clientClassRegistrationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientClassRegistrationsBindingNavigator.BackColor = System.Drawing.Color.Red;
            this.clientClassRegistrationsBindingNavigator.BindingSource = this.clientClassRegistrationsBindingSource;
            this.clientClassRegistrationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientClassRegistrationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientClassRegistrationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientClassRegistrationsBindingNavigatorSaveItem});
            this.clientClassRegistrationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientClassRegistrationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientClassRegistrationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientClassRegistrationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientClassRegistrationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientClassRegistrationsBindingNavigator.Name = "clientClassRegistrationsBindingNavigator";
            this.clientClassRegistrationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientClassRegistrationsBindingNavigator.Size = new System.Drawing.Size(620, 25);
            this.clientClassRegistrationsBindingNavigator.TabIndex = 50;
            this.clientClassRegistrationsBindingNavigator.Tag = "ONLY_ADMIN";
            this.clientClassRegistrationsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // clientClassRegistrationsBindingNavigatorSaveItem
            // 
            this.clientClassRegistrationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientClassRegistrationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientClassRegistrationsBindingNavigatorSaveItem.Image")));
            this.clientClassRegistrationsBindingNavigatorSaveItem.Name = "clientClassRegistrationsBindingNavigatorSaveItem";
            this.clientClassRegistrationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.clientClassRegistrationsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.clientClassRegistrationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientClassRegistrationsBindingNavigatorSaveItem_Click);
            // 
            // registrationIDLabel
            // 
            registrationIDLabel.AutoSize = true;
            registrationIDLabel.Location = new System.Drawing.Point(10, 31);
            registrationIDLabel.Name = "registrationIDLabel";
            registrationIDLabel.Size = new System.Drawing.Size(80, 13);
            registrationIDLabel.TabIndex = 50;
            registrationIDLabel.Text = "Registration ID:";
            // 
            // registrationIDComboBox
            // 
            this.registrationIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientClassRegistrationsBindingSource, "RegistrationID", true));
            this.registrationIDComboBox.FormattingEnabled = true;
            this.registrationIDComboBox.Location = new System.Drawing.Point(148, 28);
            this.registrationIDComboBox.Name = "registrationIDComboBox";
            this.registrationIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.registrationIDComboBox.TabIndex = 51;
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(10, 58);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(50, 13);
            clientIDLabel.TabIndex = 52;
            clientIDLabel.Text = "Client ID:";
            // 
            // clientIDComboBox
            // 
            this.clientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientClassRegistrationsBindingSource, "ClientID", true));
            this.clientIDComboBox.DataSource = this.clientsBindingSource;
            this.clientIDComboBox.DisplayMember = "ClientID";
            this.clientIDComboBox.FormattingEnabled = true;
            this.clientIDComboBox.Location = new System.Drawing.Point(148, 55);
            this.clientIDComboBox.Name = "clientIDComboBox";
            this.clientIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.clientIDComboBox.TabIndex = 53;
            // 
            // classScheduleIDLabel
            // 
            classScheduleIDLabel.AutoSize = true;
            classScheduleIDLabel.Location = new System.Drawing.Point(10, 85);
            classScheduleIDLabel.Name = "classScheduleIDLabel";
            classScheduleIDLabel.Size = new System.Drawing.Size(97, 13);
            classScheduleIDLabel.TabIndex = 54;
            classScheduleIDLabel.Text = "Class Schedule ID:";
            // 
            // classScheduleIDComboBox
            // 
            this.classScheduleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientClassRegistrationsBindingSource, "ClassScheduleID", true));
            this.classScheduleIDComboBox.DataSource = this.classSchedulesBindingSource;
            this.classScheduleIDComboBox.DisplayMember = "ClassScheduleID";
            this.classScheduleIDComboBox.FormattingEnabled = true;
            this.classScheduleIDComboBox.Location = new System.Drawing.Point(148, 82);
            this.classScheduleIDComboBox.Name = "classScheduleIDComboBox";
            this.classScheduleIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.classScheduleIDComboBox.TabIndex = 55;
            // 
            // registeredAtLabel
            // 
            registeredAtLabel.AutoSize = true;
            registeredAtLabel.Location = new System.Drawing.Point(10, 113);
            registeredAtLabel.Name = "registeredAtLabel";
            registeredAtLabel.Size = new System.Drawing.Size(74, 13);
            registeredAtLabel.TabIndex = 56;
            registeredAtLabel.Text = "Registered At:";
            // 
            // registeredAtDateTimePicker
            // 
            this.registeredAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientClassRegistrationsBindingSource, "RegisteredAt", true));
            this.registeredAtDateTimePicker.Location = new System.Drawing.Point(148, 109);
            this.registeredAtDateTimePicker.Name = "registeredAtDateTimePicker";
            this.registeredAtDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.registeredAtDateTimePicker.TabIndex = 57;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // classSchedulesBindingSource
            // 
            this.classSchedulesBindingSource.DataMember = "ClassSchedules";
            this.classSchedulesBindingSource.DataSource = this.fitnessClubDataSet;
            // 
            // classSchedulesTableAdapter
            // 
            this.classSchedulesTableAdapter.ClearBeforeFill = true;
            // 
            // ClientClassRegistrations_Form
            // 
            this.AccessibleDescription = "ClientClassRegistrations";
            this.AccessibleName = "FORM_TRANSLATE";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(620, 264);
            this.Controls.Add(registrationIDLabel);
            this.Controls.Add(this.registrationIDComboBox);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDComboBox);
            this.Controls.Add(classScheduleIDLabel);
            this.Controls.Add(this.classScheduleIDComboBox);
            this.Controls.Add(registeredAtLabel);
            this.Controls.Add(this.registeredAtDateTimePicker);
            this.Controls.Add(this.clientClassRegistrationsBindingNavigator);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(636, 303);
            this.Name = "ClientClassRegistrations_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SAVE_SIZE";
            this.Text = "Клиент регистрация";
            this.Load += new System.EventHandler(this.ClientClassRegistrations_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientClassRegistrationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientClassRegistrationsBindingNavigator)).EndInit();
            this.clientClassRegistrationsBindingNavigator.ResumeLayout(false);
            this.clientClassRegistrationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSchedulesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private FitnessClubDataSet fitnessClubDataSet;
        private System.Windows.Forms.BindingSource clientClassRegistrationsBindingSource;
        private FitnessClubDataSetTableAdapters.ClientClassRegistrationsTableAdapter clientClassRegistrationsTableAdapter;
        private FitnessClubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientClassRegistrationsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientClassRegistrationsBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox registrationIDComboBox;
        private System.Windows.Forms.ComboBox clientIDComboBox;
        private System.Windows.Forms.ComboBox classScheduleIDComboBox;
        private System.Windows.Forms.DateTimePicker registeredAtDateTimePicker;
        private FitnessClubDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private FitnessClubDataSetTableAdapters.ClassSchedulesTableAdapter classSchedulesTableAdapter;
        private System.Windows.Forms.BindingSource classSchedulesBindingSource;
    }
}