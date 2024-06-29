namespace StudentManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            checkedListBoxExtraMural = new CheckedListBox();
            grpStudentDatabase = new GroupBox();
            txtErrorSearch = new TextBox();
            labelSearchStudent = new Label();
            btnShowAll = new Button();
            dgvStudents = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            Campus = new DataGridViewTextBoxColumn();
            btnSelect = new Button();
            btnSearch = new Button();
            textBox1 = new TextBox();
            grpStudentDetails = new GroupBox();
            txtExtraMural = new TextBox();
            txtCampus = new TextBox();
            txtClass = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtGender = new TextBox();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            labelExtraMural = new Label();
            labelCampus = new Label();
            labelClass = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            labelGender = new Label();
            labelAge = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            btnExit = new Button();
            btnNewStudent = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            EnrollPanel = new Panel();
            groupBox3 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            NewStudentPanel = new Panel();
            txtErrors = new TextBox();
            btnCancel = new Button();
            btnSaveNewStudent = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label2Campus = new Label();
            comboBox1 = new ComboBox();
            label2Class = new Label();
            comboBoxClass = new ComboBox();
            groupBox1 = new GroupBox();
            checkedListBoxGender = new CheckedListBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNewEmail = new TextBox();
            txtNewPhone = new TextBox();
            txtNewAge = new TextBox();
            txtNewLastName = new TextBox();
            txtNewFirstName = new TextBox();
            tabPage2 = new TabPage();
            groupBox6 = new GroupBox();
            label11 = new Label();
            linkLabel2 = new LinkLabel();
            label10 = new Label();
            linkLabel1 = new LinkLabel();
            groupBox5 = new GroupBox();
            textBox3 = new TextBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            grpStudentDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            grpStudentDetails.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            EnrollPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            NewStudentPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBoxExtraMural
            // 
            checkedListBoxExtraMural.AccessibleRole = AccessibleRole.None;
            checkedListBoxExtraMural.BackColor = SystemColors.Control;
            checkedListBoxExtraMural.BorderStyle = BorderStyle.None;
            checkedListBoxExtraMural.Font = new Font("Segoe UI", 12F);
            checkedListBoxExtraMural.FormattingEnabled = true;
            checkedListBoxExtraMural.Items.AddRange(new object[] { "Yes", "No" });
            checkedListBoxExtraMural.Location = new Point(13, 280);
            checkedListBoxExtraMural.MultiColumn = true;
            checkedListBoxExtraMural.Name = "checkedListBoxExtraMural";
            checkedListBoxExtraMural.Size = new Size(268, 24);
            checkedListBoxExtraMural.TabIndex = 4;
            checkedListBoxExtraMural.ItemCheck += checkedListBoxExtraMural_ItemCheck;
            // 
            // grpStudentDatabase
            // 
            grpStudentDatabase.Controls.Add(txtErrorSearch);
            grpStudentDatabase.Controls.Add(labelSearchStudent);
            grpStudentDatabase.Controls.Add(btnShowAll);
            grpStudentDatabase.Controls.Add(dgvStudents);
            grpStudentDatabase.Controls.Add(btnSelect);
            grpStudentDatabase.Controls.Add(btnSearch);
            grpStudentDatabase.Controls.Add(textBox1);
            grpStudentDatabase.Font = new Font("Segoe UI", 13F);
            grpStudentDatabase.ForeColor = SystemColors.ControlDarkDark;
            grpStudentDatabase.Location = new Point(9, 9);
            grpStudentDatabase.Name = "grpStudentDatabase";
            grpStudentDatabase.Size = new Size(902, 365);
            grpStudentDatabase.TabIndex = 1;
            grpStudentDatabase.TabStop = false;
            grpStudentDatabase.Text = "Student Database";
            // 
            // txtErrorSearch
            // 
            txtErrorSearch.BackColor = SystemColors.Control;
            txtErrorSearch.BorderStyle = BorderStyle.None;
            txtErrorSearch.ForeColor = Color.Red;
            txtErrorSearch.Location = new Point(8, 327);
            txtErrorSearch.Name = "txtErrorSearch";
            txtErrorSearch.Size = new Size(715, 24);
            txtErrorSearch.TabIndex = 7;
            // 
            // labelSearchStudent
            // 
            labelSearchStudent.AutoSize = true;
            labelSearchStudent.Location = new Point(170, 45);
            labelSearchStudent.Name = "labelSearchStudent";
            labelSearchStudent.Size = new Size(134, 25);
            labelSearchStudent.TabIndex = 6;
            labelSearchStudent.Text = "Search Student:";
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = SystemColors.Control;
            btnShowAll.BackgroundImageLayout = ImageLayout.Center;
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = SystemColors.ControlDarkDark;
            btnShowAll.Location = new Point(790, 42);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 30);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseMnemonic = false;
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { Id, FullName, Email, Class, Campus });
            dgvStudents.Location = new Point(8, 80);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvStudents.Size = new Size(882, 241);
            dgvStudents.TabIndex = 4;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FullName.HeaderText = "Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 260;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 300;
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.Name = "Class";
            Class.ReadOnly = true;
            Class.Width = 120;
            // 
            // Campus
            // 
            Campus.HeaderText = "Campus";
            Campus.Name = "Campus";
            Campus.ReadOnly = true;
            Campus.Width = 179;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Segoe UI", 14F);
            btnSelect.Location = new Point(790, 327);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(100, 32);
            btnSelect.TabIndex = 3;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 14F);
            btnSearch.Location = new Point(593, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseCompatibleTextRendering = true;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(307, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 31);
            textBox1.TabIndex = 1;
            // 
            // grpStudentDetails
            // 
            grpStudentDetails.Controls.Add(txtExtraMural);
            grpStudentDetails.Controls.Add(txtCampus);
            grpStudentDetails.Controls.Add(txtClass);
            grpStudentDetails.Controls.Add(txtEmail);
            grpStudentDetails.Controls.Add(txtPhone);
            grpStudentDetails.Controls.Add(txtGender);
            grpStudentDetails.Controls.Add(txtAge);
            grpStudentDetails.Controls.Add(txtLastName);
            grpStudentDetails.Controls.Add(txtFirstName);
            grpStudentDetails.Controls.Add(labelExtraMural);
            grpStudentDetails.Controls.Add(labelCampus);
            grpStudentDetails.Controls.Add(labelClass);
            grpStudentDetails.Controls.Add(labelEmail);
            grpStudentDetails.Controls.Add(labelPhone);
            grpStudentDetails.Controls.Add(labelGender);
            grpStudentDetails.Controls.Add(labelAge);
            grpStudentDetails.Controls.Add(labelLastName);
            grpStudentDetails.Controls.Add(labelFirstName);
            grpStudentDetails.Controls.Add(btnEdit);
            grpStudentDetails.Controls.Add(btnDelete);
            grpStudentDetails.Font = new Font("Segoe UI", 14F);
            grpStudentDetails.ForeColor = SystemColors.ControlDarkDark;
            grpStudentDetails.Location = new Point(12, 19);
            grpStudentDetails.Name = "grpStudentDetails";
            grpStudentDetails.Size = new Size(902, 262);
            grpStudentDetails.TabIndex = 2;
            grpStudentDetails.TabStop = false;
            grpStudentDetails.Text = "Student Details";
            grpStudentDetails.UseWaitCursor = true;
            // 
            // txtExtraMural
            // 
            txtExtraMural.BorderStyle = BorderStyle.None;
            txtExtraMural.Cursor = Cursors.No;
            txtExtraMural.Font = new Font("Segoe UI", 14F);
            txtExtraMural.Location = new Point(604, 120);
            txtExtraMural.Name = "txtExtraMural";
            txtExtraMural.ReadOnly = true;
            txtExtraMural.Size = new Size(260, 25);
            txtExtraMural.TabIndex = 19;
            txtExtraMural.UseWaitCursor = true;
            // 
            // txtCampus
            // 
            txtCampus.BorderStyle = BorderStyle.None;
            txtCampus.Cursor = Cursors.No;
            txtCampus.Font = new Font("Segoe UI", 14F);
            txtCampus.Location = new Point(604, 85);
            txtCampus.Name = "txtCampus";
            txtCampus.ReadOnly = true;
            txtCampus.Size = new Size(260, 25);
            txtCampus.TabIndex = 18;
            txtCampus.UseWaitCursor = true;
            // 
            // txtClass
            // 
            txtClass.BorderStyle = BorderStyle.None;
            txtClass.Cursor = Cursors.No;
            txtClass.Font = new Font("Segoe UI", 14F);
            txtClass.Location = new Point(604, 50);
            txtClass.Name = "txtClass";
            txtClass.ReadOnly = true;
            txtClass.Size = new Size(260, 25);
            txtClass.TabIndex = 17;
            txtClass.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.No;
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(159, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(260, 25);
            txtEmail.TabIndex = 16;
            txtEmail.UseWaitCursor = true;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Cursor = Cursors.No;
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(159, 190);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(260, 25);
            txtPhone.TabIndex = 15;
            txtPhone.UseWaitCursor = true;
            // 
            // txtGender
            // 
            txtGender.BorderStyle = BorderStyle.None;
            txtGender.Cursor = Cursors.No;
            txtGender.Font = new Font("Segoe UI", 14F);
            txtGender.Location = new Point(159, 155);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(260, 25);
            txtGender.TabIndex = 14;
            txtGender.UseWaitCursor = true;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Cursor = Cursors.No;
            txtAge.Font = new Font("Segoe UI", 14F);
            txtAge.Location = new Point(159, 120);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(260, 25);
            txtAge.TabIndex = 13;
            txtAge.UseWaitCursor = true;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Cursor = Cursors.No;
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(159, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(260, 25);
            txtLastName.TabIndex = 12;
            txtLastName.UseWaitCursor = true;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Cursor = Cursors.No;
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.Location = new Point(159, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(260, 25);
            txtFirstName.TabIndex = 11;
            txtFirstName.UseWaitCursor = true;
            // 
            // labelExtraMural
            // 
            labelExtraMural.AutoSize = true;
            labelExtraMural.Font = new Font("Segoe UI", 14F);
            labelExtraMural.Location = new Point(467, 123);
            labelExtraMural.Name = "labelExtraMural";
            labelExtraMural.Size = new Size(108, 25);
            labelExtraMural.TabIndex = 10;
            labelExtraMural.Text = "ExtraMural:";
            labelExtraMural.TextAlign = ContentAlignment.MiddleCenter;
            labelExtraMural.UseWaitCursor = true;
            // 
            // labelCampus
            // 
            labelCampus.AutoSize = true;
            labelCampus.Font = new Font("Segoe UI", 14F);
            labelCampus.Location = new Point(467, 88);
            labelCampus.Name = "labelCampus";
            labelCampus.Size = new Size(84, 25);
            labelCampus.TabIndex = 9;
            labelCampus.Text = "Campus:";
            labelCampus.UseWaitCursor = true;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI", 14F);
            labelClass.Location = new Point(467, 53);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(59, 25);
            labelClass.TabIndex = 8;
            labelClass.Text = "Class:";
            labelClass.UseWaitCursor = true;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14F);
            labelEmail.Location = new Point(8, 228);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(62, 25);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email:";
            labelEmail.UseWaitCursor = true;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 14F);
            labelPhone.Location = new Point(8, 193);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(70, 25);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Phone:";
            labelPhone.UseWaitCursor = true;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 14F);
            labelGender.Location = new Point(8, 158);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(78, 25);
            labelGender.TabIndex = 5;
            labelGender.Text = "Gender:";
            labelGender.UseWaitCursor = true;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 14F);
            labelAge.Location = new Point(8, 123);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(49, 25);
            labelAge.TabIndex = 4;
            labelAge.Text = "Age:";
            labelAge.UseWaitCursor = true;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 14F);
            labelLastName.Location = new Point(8, 88);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(104, 25);
            labelLastName.TabIndex = 3;
            labelLastName.Text = "Last Name:";
            labelLastName.UseWaitCursor = true;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 14F);
            labelFirstName.Location = new Point(8, 53);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(106, 25);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name:";
            labelFirstName.UseWaitCursor = true;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Font = new Font("Segoe UI", 14F);
            btnEdit.Location = new Point(684, 224);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.UseWaitCursor = true;
            btnEdit.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 14F);
            btnDelete.Location = new Point(790, 224);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 32);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.UseWaitCursor = true;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Underline);
            label1.Location = new Point(172, 6);
            label1.Name = "label1";
            label1.Size = new Size(592, 59);
            label1.TabIndex = 3;
            label1.Text = "Student Management System:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F);
            btnExit.Location = new Point(9, 765);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnNewStudent
            // 
            btnNewStudent.BackColor = SystemColors.HotTrack;
            btnNewStudent.Cursor = Cursors.Hand;
            btnNewStudent.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewStudent.ForeColor = SystemColors.Control;
            btnNewStudent.Location = new Point(697, 759);
            btnNewStudent.Name = "btnNewStudent";
            btnNewStudent.Size = new Size(206, 44);
            btnNewStudent.TabIndex = 5;
            btnNewStudent.Text = "New Student";
            btnNewStudent.UseVisualStyleBackColor = false;
            btnNewStudent.Click += btnNewStudent_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(grpStudentDatabase);
            panel1.Location = new Point(0, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 381);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(EnrollPanel);
            panel2.Controls.Add(grpStudentDetails);
            panel2.Location = new Point(1, 449);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 284);
            panel2.TabIndex = 7;
            // 
            // EnrollPanel
            // 
            EnrollPanel.Controls.Add(groupBox3);
            EnrollPanel.Location = new Point(-1, 1);
            EnrollPanel.Name = "EnrollPanel";
            EnrollPanel.Size = new Size(927, 286);
            EnrollPanel.TabIndex = 3;
            EnrollPanel.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 14F);
            groupBox3.Location = new Point(13, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(898, 253);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Enrollment File Check:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-4, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(931, 760);
            tabControl1.TabIndex = 20;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.Controls.Add(NewStudentPanel);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(923, 732);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Students";
            // 
            // NewStudentPanel
            // 
            NewStudentPanel.Controls.Add(txtErrors);
            NewStudentPanel.Controls.Add(btnCancel);
            NewStudentPanel.Controls.Add(btnSaveNewStudent);
            NewStudentPanel.Controls.Add(groupBox2);
            NewStudentPanel.Controls.Add(groupBox1);
            NewStudentPanel.Location = new Point(0, 68);
            NewStudentPanel.Name = "NewStudentPanel";
            NewStudentPanel.Size = new Size(924, 382);
            NewStudentPanel.TabIndex = 8;
            NewStudentPanel.Visible = false;
            // 
            // txtErrors
            // 
            txtErrors.BackColor = SystemColors.Control;
            txtErrors.BorderStyle = BorderStyle.None;
            txtErrors.Font = new Font("Segoe UI", 14F);
            txtErrors.Location = new Point(21, 340);
            txtErrors.Name = "txtErrors";
            txtErrors.Size = new Size(584, 25);
            txtErrors.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14F);
            btnCancel.Location = new Point(811, 338);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 32);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveNewStudent
            // 
            btnSaveNewStudent.Font = new Font("Segoe UI", 14F);
            btnSaveNewStudent.Location = new Point(697, 338);
            btnSaveNewStudent.Name = "btnSaveNewStudent";
            btnSaveNewStudent.Size = new Size(100, 32);
            btnSaveNewStudent.TabIndex = 2;
            btnSaveNewStudent.Text = "SAVE";
            btnSaveNewStudent.UseVisualStyleBackColor = true;
            btnSaveNewStudent.Click += btnSaveNewStudent_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(checkedListBoxExtraMural);
            groupBox2.Controls.Add(label2Campus);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label2Class);
            groupBox2.Controls.Add(comboBoxClass);
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.ForeColor = SystemColors.ControlDarkDark;
            groupBox2.Location = new Point(617, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 321);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Study Details:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(7, 239);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 5;
            label2.Text = "ExtraMural:";
            // 
            // label2Campus
            // 
            label2Campus.AutoSize = true;
            label2Campus.ForeColor = SystemColors.ActiveCaptionText;
            label2Campus.Location = new Point(6, 144);
            label2Campus.Name = "label2Campus";
            label2Campus.Size = new Size(84, 25);
            label2Campus.TabIndex = 3;
            label2Campus.Text = "Campus:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Christchurch", "Wellington", "Auckland" });
            comboBox1.Location = new Point(6, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 33);
            comboBox1.TabIndex = 2;
            // 
            // label2Class
            // 
            label2Class.AutoSize = true;
            label2Class.ForeColor = SystemColors.ActiveCaptionText;
            label2Class.Location = new Point(6, 48);
            label2Class.Name = "label2Class";
            label2Class.Size = new Size(59, 25);
            label2Class.TabIndex = 1;
            label2Class.Text = "Class:";
            // 
            // comboBoxClass
            // 
            comboBoxClass.AllowDrop = true;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "IT 6537", "IT 1234", "IT 5673" });
            comboBoxClass.Location = new Point(6, 80);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(282, 33);
            comboBoxClass.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(checkedListBoxGender);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNewEmail);
            groupBox1.Controls.Add(txtNewPhone);
            groupBox1.Controls.Add(txtNewAge);
            groupBox1.Controls.Add(txtNewLastName);
            groupBox1.Controls.Add(txtNewFirstName);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(13, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 321);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Student Details:";
            // 
            // checkedListBoxGender
            // 
            checkedListBoxGender.BackColor = SystemColors.Control;
            checkedListBoxGender.BorderStyle = BorderStyle.None;
            checkedListBoxGender.CheckOnClick = true;
            checkedListBoxGender.Font = new Font("Segoe UI", 12F);
            checkedListBoxGender.FormattingEnabled = true;
            checkedListBoxGender.HorizontalScrollbar = true;
            checkedListBoxGender.IntegralHeight = false;
            checkedListBoxGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            checkedListBoxGender.Location = new Point(306, 175);
            checkedListBoxGender.MultiColumn = true;
            checkedListBoxGender.Name = "checkedListBoxGender";
            checkedListBoxGender.Size = new Size(277, 54);
            checkedListBoxGender.TabIndex = 11;
            checkedListBoxGender.UseTabStops = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(306, 239);
            label8.Name = "label8";
            label8.Size = new Size(134, 25);
            label8.TabIndex = 10;
            label8.Text = "Email Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(8, 239);
            label7.Name = "label7";
            label7.Size = new Size(144, 25);
            label7.TabIndex = 9;
            label7.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(306, 144);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 8;
            label6.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(8, 144);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 7;
            label5.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(306, 48);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 6;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(8, 48);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 5;
            label3.Text = "First Name:";
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(306, 278);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(277, 32);
            txtNewEmail.TabIndex = 4;
            // 
            // txtNewPhone
            // 
            txtNewPhone.Location = new Point(8, 278);
            txtNewPhone.Name = "txtNewPhone";
            txtNewPhone.Size = new Size(280, 32);
            txtNewPhone.TabIndex = 3;
            // 
            // txtNewAge
            // 
            txtNewAge.Location = new Point(8, 182);
            txtNewAge.Name = "txtNewAge";
            txtNewAge.Size = new Size(280, 32);
            txtNewAge.TabIndex = 2;
            // 
            // txtNewLastName
            // 
            txtNewLastName.BackColor = SystemColors.Window;
            txtNewLastName.Location = new Point(306, 81);
            txtNewLastName.Name = "txtNewLastName";
            txtNewLastName.Size = new Size(280, 32);
            txtNewLastName.TabIndex = 1;
            // 
            // txtNewFirstName
            // 
            txtNewFirstName.Location = new Point(8, 81);
            txtNewFirstName.Name = "txtNewFirstName";
            txtNewFirstName.Size = new Size(280, 32);
            txtNewFirstName.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 732);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "App Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(linkLabel2);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(linkLabel1);
            groupBox6.Font = new Font("Segoe UI", 14F);
            groupBox6.ForeColor = SystemColors.ControlDarkDark;
            groupBox6.Location = new Point(12, 609);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(899, 96);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Links";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(577, 48);
            label11.Name = "label11";
            label11.Size = new Size(109, 25);
            label11.TabIndex = 3;
            label11.Text = "My Github: ";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(713, 48);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(134, 25);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "View my page:";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 48);
            label10.Name = "label10";
            label10.Size = new Size(112, 25);
            label10.TabIndex = 1;
            label10.Text = "Whitecliffe: ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkVisited = true;
            linkLabel1.Location = new Point(124, 48);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(155, 25);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here to visit";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox3);
            groupBox5.Font = new Font("Segoe UI", 14F);
            groupBox5.ForeColor = SystemColors.ControlDarkDark;
            groupBox5.Location = new Point(12, 527);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(899, 76);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Developer Information";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(6, 31);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(887, 25);
            textBox3.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 32F, FontStyle.Underline);
            label9.Location = new Point(172, 6);
            label9.Name = "label9";
            label9.Size = new Size(592, 59);
            label9.TabIndex = 4;
            label9.Text = "Student Management System:";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Font = new Font("Segoe UI", 14F);
            groupBox4.ForeColor = SystemColors.ControlDarkDark;
            groupBox4.Location = new Point(12, 68);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(899, 453);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Application Purpose";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 31);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(887, 416);
            textBox2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 809);
            Controls.Add(tabControl1);
            Controls.Add(btnNewStudent);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Student Management System";
            grpStudentDatabase.ResumeLayout(false);
            grpStudentDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            grpStudentDetails.ResumeLayout(false);
            grpStudentDetails.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            EnrollPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            NewStudentPanel.ResumeLayout(false);
            NewStudentPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpStudentDatabase;
        private GroupBox grpStudentDetails;
        private TextBox textBox1;
        private Button btnSearch;
        private Button btnSelect;
        private Label label1;
        private Button btnEdit;
        private Button btnDelete;
        private Label labelFirstName;
        private Label labelAge;
        private Label labelLastName;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelGender;
        private Label labelCampus;
        private Label labelClass;
        private Label labelExtraMural;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtGender;
        private TextBox txtAge;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtExtraMural;
        private TextBox txtCampus;
        private TextBox txtClass;
        private Button btnExit;
        private Button btnNewStudent;
        private DataGridView dgvStudents;
        private Button btnShowAll;
        private Label labelSearchStudent;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtErrorSearch;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Campus;
        private Panel NewStudentPanel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBoxClass;
        private Label label2Campus;
        private ComboBox comboBox1;
        private Label label2Class;
        private Label label2;
        private CheckedListBox checkedListBoxExtraMural;
        private TextBox txtNewPhone;
        private TextBox txtNewAge;
        private TextBox txtNewLastName;
        private TextBox txtNewFirstName;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNewEmail;
        private CheckedListBox checkedListBoxGender;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel EnrollPanel;
        private GroupBox groupBox3;
        private Button btnSaveNewStudent;
        private Button btnCancel;
        private OpenFileDialog openFileDialog1;
        private TextBox txtErrors;
        private Label label9;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private TextBox textBox2;
        private TextBox textBox3;
        private LinkLabel linkLabel1;
        private Label label10;
        private Label label11;
        private LinkLabel linkLabel2;
    }
}
