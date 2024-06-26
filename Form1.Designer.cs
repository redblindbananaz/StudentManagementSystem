﻿namespace StudentManagementSystem
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
            grpStudentDatabase = new GroupBox();
            dgvStudents = new DataGridView();
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
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            Campus = new DataGridViewTextBoxColumn();
            grpStudentDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            grpStudentDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grpStudentDatabase
            // 
            grpStudentDatabase.Controls.Add(dgvStudents);
            grpStudentDatabase.Controls.Add(btnSelect);
            grpStudentDatabase.Controls.Add(btnSearch);
            grpStudentDatabase.Controls.Add(textBox1);
            grpStudentDatabase.Font = new Font("Segoe UI", 13F);
            grpStudentDatabase.ForeColor = SystemColors.ControlDarkDark;
            grpStudentDatabase.Location = new Point(12, 75);
            grpStudentDatabase.Name = "grpStudentDatabase";
            grpStudentDatabase.Size = new Size(896, 365);
            grpStudentDatabase.TabIndex = 1;
            grpStudentDatabase.TabStop = false;
            grpStudentDatabase.Text = "Student Database";
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
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 14F);
            btnSearch.Location = new Point(604, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(307, 42);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By Student Name";
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
            grpStudentDetails.Font = new Font("Segoe UI", 20F);
            grpStudentDetails.ForeColor = SystemColors.ControlDarkDark;
            grpStudentDetails.Location = new Point(12, 474);
            grpStudentDetails.Name = "grpStudentDetails";
            grpStudentDetails.Size = new Size(896, 262);
            grpStudentDetails.TabIndex = 2;
            grpStudentDetails.TabStop = false;
            grpStudentDetails.Text = "Student Details";
            grpStudentDetails.UseWaitCursor = true;
            // 
            // txtExtraMural
            // 
            txtExtraMural.Font = new Font("Segoe UI", 14F);
            txtExtraMural.Location = new Point(604, 120);
            txtExtraMural.Name = "txtExtraMural";
            txtExtraMural.Size = new Size(260, 32);
            txtExtraMural.TabIndex = 19;
            txtExtraMural.UseWaitCursor = true;
            // 
            // txtCampus
            // 
            txtCampus.Font = new Font("Segoe UI", 14F);
            txtCampus.Location = new Point(604, 85);
            txtCampus.Name = "txtCampus";
            txtCampus.Size = new Size(260, 32);
            txtCampus.TabIndex = 18;
            txtCampus.UseWaitCursor = true;
            // 
            // txtClass
            // 
            txtClass.Font = new Font("Segoe UI", 14F);
            txtClass.Location = new Point(604, 50);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(260, 32);
            txtClass.TabIndex = 17;
            txtClass.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(159, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 32);
            txtEmail.TabIndex = 16;
            txtEmail.UseWaitCursor = true;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F);
            txtPhone.Location = new Point(159, 190);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(260, 32);
            txtPhone.TabIndex = 15;
            txtPhone.UseWaitCursor = true;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 14F);
            txtGender.Location = new Point(159, 155);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(260, 32);
            txtGender.TabIndex = 14;
            txtGender.UseWaitCursor = true;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 14F);
            txtAge.Location = new Point(159, 120);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(260, 32);
            txtAge.TabIndex = 13;
            txtAge.UseWaitCursor = true;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14F);
            txtLastName.Location = new Point(159, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(260, 32);
            txtLastName.TabIndex = 12;
            txtLastName.UseWaitCursor = true;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14F);
            txtFirstName.Location = new Point(159, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(260, 32);
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Underline);
            label1.Location = new Point(182, 9);
            label1.Name = "label1";
            label1.Size = new Size(592, 59);
            label1.TabIndex = 3;
            label1.Text = "Student Management System:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F);
            btnExit.Location = new Point(12, 765);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnNewStudent
            // 
            btnNewStudent.BackColor = SystemColors.ActiveCaptionText;
            btnNewStudent.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewStudent.ForeColor = SystemColors.Control;
            btnNewStudent.Location = new Point(696, 765);
            btnNewStudent.Name = "btnNewStudent";
            btnNewStudent.Size = new Size(206, 32);
            btnNewStudent.TabIndex = 5;
            btnNewStudent.Text = "New Student";
            btnNewStudent.UseVisualStyleBackColor = false;
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
            Campus.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 809);
            Controls.Add(btnNewStudent);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(grpStudentDetails);
            Controls.Add(grpStudentDatabase);
            Name = "Form1";
            Text = "Form1";
            grpStudentDatabase.ResumeLayout(false);
            grpStudentDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            grpStudentDetails.ResumeLayout(false);
            grpStudentDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Campus;
    }
}