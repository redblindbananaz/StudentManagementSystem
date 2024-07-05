using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using StudentManagementSystem.Models;
/*
 * STUDENT MANAGEMENT SYSTEM
 * Student ID : 20210862
 * 
 * DESCRIPTION:
 * This Windows Form application manages student information through a GUI interface With 2 tabs.
 * 
 * FEATURES:
 * - Tab1: Student Operations
 *      - Displays a list of students in a DataGridView with details preview.
 *      - Search functionality with notifications for non-existent students.
 *      - Edit and Delete functionality with confirmation dialogs, appears when a student is selected.
 *      - Edit: Modify student details in a separate panel, with validation and feedback.
 *      - Delete: Remove a student from the list with confirmation dialog.
 *      - New Student: Add a new student to the list with validation and feedback.
 *  
 *  - Tab2: Application Information
 *      - Disaply app description, author information and external links to the campus website and GitHub.
 *      
 * ADDITIONAL FUNCTIONALITIES:
 *      - Custom events for notifying data changes.
 *      - Error handling and validation for user input.
 *      - File I/O operations to load , modify and save text files.
 *      - Age validation to ensure numeric input.
 * 
 * This project includes a seperate validation file and a model folder for future expansion ( ex. Teacher class, etc...)
 * 
 * NOTE:
 *  - This project have been created on a MacM1 using VMWare with Windows 11 and Visual Studio 2022 and Git.
 *      
 */

namespace StudentManagementSystem
{

    public partial class Form1 : Form
    {
        //Delegate for the event handler:
        public delegate void StudentListChangedEventHandler(object sender, EventArgs e);
        //Declare the event:
        public event StudentListChangedEventHandler StudentListChanged;

        private List<Student> students;
        private List<Student> newStudents;
        private bool isFormLoaded = false;
        private bool isEditMode = false;
        private int editingStudentId = -1;
        private int selectedRowIndex = -1;
        private BindingList<Student> filteredStudents;
        public Form1()
        {
            InitializeComponent();
            InitailizeTextBoxes();
            InitializeStudentData();
            PopulateStudentList();

            //Configure the checkedListBox:
            ConfigureCheckedListBox(checkedListBoxGender);
            ConfigureCheckedListBox(checkedListBoxExtraMural);

            //Need to set the selection mode to fullrowselect according to microsoft documentation
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Flag to check if form is loaded while testing with message boxes
            isFormLoaded = true;

            //Subscribe to the custom event:
            this.StudentListChanged += new StudentListChangedEventHandler(this.Form1_StudentListChanged);
        }

        // Method to raise the custom event:
        protected virtual void OnStudentListChanged()
        {
            StudentListChanged?.Invoke(this, EventArgs.Empty);
        }

        // Event handler for the custom event:
        private void Form1_StudentListChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Student List Changed", "Info Notifications:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void InitailizeTextBoxes()
        {
            textBox2.Text = "This application is designed to demonstrate the use of Windows Forms elements and event programming.\r\nIt manages a list of students, allowing uers to view/search student records, and also add, edit and delete student.\r\nThe features of this application:Custom Event using the publisher/subscriber pattern. User get notification each time the records are modified upon deletion, creation or on edit\r\nData Validation: The application validates the data entered by the user and provides feedback to the user\r\nThe application showcases various controls such as DataGridView, Tabs, Panel, TextBox, ComboBox, CheckedListBox, Button, etc.\r\nDesign: The application is designed to be user-friendly and intuitive. The user can easily navigate between the different sections of the application.\r\nThe application is designed to be responsive and provide feedback to the user when an action is performed.\r\nThe application demonstrates the use of working with Text files, using FileDialogs to open and save files.\r\n";
            textBox3.Text = "Sebastien Pernot - 20210862";
        }

        public void InitializeStudentData()
        {
            students = new List<Student>
            {
                new Student(1,"John", "Doe", 20, "Male", "1234567890", "john.doe@gmail.com","IT 1234","Auckland",true),
                new Student(2, "Jane", "Smith", 24, "Female", "9934567890", "jane.smith@gmail.com","IT 6537","Wellington",false),
                new Student(3, "foo", "bar",21, "Other", "1234567890", "foo.bar@gmail.com","IT 5673","Christchurch",true),

            };

        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {

            if (!isFormLoaded)

                return;
            if (dgvStudents.SelectedRows.Count > 0)
            {
                selectedRowIndex = dgvStudents.SelectedRows[0].Index;
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < dgvStudents.Rows.Count)
            {

                var selectedRow = dgvStudents.SelectedRows[0];
                int selectedId = (int)selectedRow.Cells[0].Value;
                var selectedStudent = students.FirstOrDefault(s => s.Id == selectedId);

                if (selectedStudent != null)
                {
                    txtFirstName.Text = selectedStudent.FirstName;
                    txtLastName.Text = selectedStudent.LastName;
                    txtAge.Text = selectedStudent.Age;
                    txtGender.Text = selectedStudent.Gender;
                    txtPhone.Text = selectedStudent.PhoneNumber;
                    txtEmail.Text = selectedStudent.Email;
                    txtClass.Text = selectedStudent.ClassName;
                    txtCampus.Text = selectedStudent.Campus;
                    txtExtraMural.Text = BooleanConverter.Convert(selectedStudent.ExtraMural);

                    btnEdit.Enabled = true;
                    btnEdit.Visible = true;
                    btnDelete.Enabled = true;
                    btnDelete.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Selected student is null");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Leaving the Student Management System?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void PopulateStudentList()
        {
            dgvStudents.Rows.Clear();
            foreach (var student in students)
            {
                dgvStudents.Rows.Add(student.Id, student.FullName, student.Email, student.ClassName, student.Campus);
            }
            ClearForm();
        }

        public static class BooleanConverter
        {
            public static string Convert(bool value)
            {
                return value ? "Yes" : "No";
            }
        }
        private void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtClass.Text = string.Empty;
            txtCampus.Text = string.Empty;
            txtExtraMural.Text = string.Empty;

            btnEdit.Enabled = false;
            btnEdit.Visible = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < dgvStudents.Rows.Count)
            {
                var selectedRow = dgvStudents.SelectedRows[0];
                int selectedId = (int)selectedRow.Cells[0].Value;
                var studentToRemove = students.FirstOrDefault(s => s.Id == selectedId);

                if (studentToRemove != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete this student: {studentToRemove.FullName}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        students.Remove(studentToRemove);
                        PopulateStudentList();
                        ClearForm();
                        OnStudentListChanged();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            NewStudentPanel.Visible = true;
            groupBox1.Text = "Edit Student";
            groupBox2.Text = "Previous Student Details:";
            btnEdit.Enabled = false;
            btnEdit.Visible = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;


            if (selectedRowIndex >= 0 && selectedRowIndex < dgvStudents.Rows.Count)
            {

                var selectedRow = dgvStudents.SelectedRows[0];
                int selectedId = (int)selectedRow.Cells[0].Value;
                var studentToEdit = students.FirstOrDefault(s => s.Id == selectedId);

                if (studentToEdit != null)
                {
                    isEditMode = true;
                    editingStudentId = selectedId;

                    txtNewFirstName.Text = studentToEdit.FirstName;
                    txtNewLastName.Text = studentToEdit.LastName;
                    txtNewAge.Text = studentToEdit.Age;
                    SetCheckedListBoxSelection(checkedListBoxGender, studentToEdit.Gender);
                    txtNewPhone.Text= studentToEdit.PhoneNumber;
                    txtNewEmail.Text= studentToEdit.Email;
                    comboBoxClass.SelectedItem= studentToEdit.ClassName;
                    comboBox1.SelectedItem= studentToEdit.Campus;
                    SetCheckedListBoxSelection(checkedListBoxExtraMural, BooleanConverter.Convert(studentToEdit.ExtraMural));
                }
       
            }
            else
            {
                MessageBox.Show("Selected student is null");
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                //If the search is empty, show all students
                filteredStudents = new BindingList<Student>(students);
                txtErrorSearch.Text = string.Empty;

            }
            else
            {
                // Otherwise search based on the search term
                filteredStudents = new BindingList<Student>(students.Where(s => s.FirstName.ToLower().Contains(searchTerm) || s.LastName.ToLower().Contains(searchTerm)).ToList());
                if (filteredStudents.Count == 0)
                {
                    txtErrorSearch.Text = $"* Sorry, No students found for: {searchTerm} Search";
                }
                else
                {
                    txtErrorSearch.Text = string.Empty;
                }
            }
            ClearForm();
            dgvStudents.Rows.Clear();
            foreach (var student in filteredStudents)
            {
                dgvStudents.Rows.Add(student.Id, student.FullName, student.Email, student.ClassName, student.Campus);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ClearForm();
            PopulateStudentList();
            textBox1.Text = string.Empty;
            txtErrorSearch.Text = string.Empty;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                btnNewStudent.Visible = true;
            }
            else
            {
                btnNewStudent.Visible = false;

            }
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            NewStudentPanel.Visible = true;
            EnrollPanel.Visible = true;
        }

        private int GenerateNewStudentId()
        {
            return students.Any() ? students.Max(s=>s.Id) +1 : 1;
        }

        private void ConfigureCheckedListBox(CheckedListBox checkedListBox)
        {
            checkedListBox.ItemCheck += (sender, e) =>
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < checkedListBox.Items.Count; i++)
                    {
                        if (i != e.Index)
                        {
                            checkedListBox.SetItemChecked(i, false);
                        }
                    }
                }
            };
        }

        private string GetCheckedListBoxSelection (CheckedListBox checkedListBox)
        {
            return checkedListBox.CheckedItems.Count > 0 ? checkedListBox.CheckedItems[0].ToString() : string.Empty;
        }

        private void SetCheckedListBoxSelection(CheckedListBox checkedListBox, string selection)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, checkedListBox.Items[i].ToString() == selection);
            }
        }
            

        private void btnSaveNewStudent_Click(object sender, EventArgs e)
        {
            //Need to validate the input before saving the new student:
            if (NewStudentInputIsValidated())
            {
                if (isEditMode)
                {
                    var studentToEdit = students.FirstOrDefault(s => s.Id == editingStudentId);
                    if (studentToEdit != null)
                    {
                        studentToEdit.FirstName = txtNewFirstName.Text;
                        studentToEdit.LastName = txtNewLastName.Text;
                        studentToEdit.Age = txtNewAge.Text;
                        studentToEdit.Gender = GetCheckedListBoxSelection(checkedListBoxGender);
                        studentToEdit.PhoneNumber = txtNewPhone.Text;
                        studentToEdit.Email = txtNewEmail.Text;
                        studentToEdit.ClassName = comboBoxClass.SelectedItem?.ToString();
                        studentToEdit.Campus = comboBox1.SelectedItem?.ToString();
                        studentToEdit.ExtraMural = checkedListBoxExtraMural.CheckedItems.Contains("Yes");

                        OnStudentListChanged();// Trigger the Custom Event.
                    }
                }
                else
                {
                    var newStudent = new Student(
                        GenerateNewStudentId(),
                        txtNewFirstName.Text,
                        txtNewLastName.Text,
                        int.Parse(txtNewAge.Text),
                        GetCheckedListBoxSelection(checkedListBoxGender),
                        txtNewPhone.Text,
                        txtNewEmail.Text,
                        comboBoxClass.SelectedItem?.ToString(),
                        comboBox1.SelectedItem?.ToString(),
                        checkedListBoxExtraMural.CheckedItems.Contains("Yes")
                        );

                    students.Add(newStudent);
                    OnStudentListChanged();// Trigger the Custom Event.
                }

                PopulateStudentList();

                NewStudentPanel.Visible = false;
                EnrollPanel.Visible = false;
                panel1.Visible = true;
                panel2.Visible = true;
                ClearNewStudentForm();

                //Reset the flags:
                isEditMode = false;
                editingStudentId = -1;
            }
        }


        private void checkedListBoxExtraMural_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListBoxExtraMural.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBoxExtraMural.SetItemChecked(i, false);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateStudentList();

            NewStudentPanel.Visible = false;
            EnrollPanel.Visible = false;
            panel1.Visible = true;
            panel2.Visible = true;
            ClearNewStudentForm();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                linkLabel1.LinkVisited = true;
                Process.Start(new ProcessStartInfo { FileName = @"https://whitecliffe.ac.nz", UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel2.LinkVisited = true;
                Process.Start(new ProcessStartInfo { FileName = @"https://github.com/redblindbananaz", UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            TextReader tr = null;
            String line;
            opnTextFile.Filter = "Text Files(*.txt)|*.txt|" + "All FIles(*.*)|*.*";
            opnTextFile.ShowDialog();

            if (opnTextFile.FileName != "")
            {
                try
                {
                    tr = File.OpenText(opnTextFile.FileName);
                    textBox4.Clear();

                    while ((line =tr.ReadLine()) !=null)
                    {
                      
                            textBox4.Text += line + "\r\n";
                     
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tr?.Close();
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            TextWriter tw = null;
            savTextFile.Filter = "Text Files(*.txt)|*.txt|" + "All FIles(*.*)|*.*";
            savTextFile.ShowDialog();

            if (savTextFile.FileName != "")
            {
                try
                {
                    tw = File.CreateText(savTextFile.FileName);
    
                    foreach (string line in textBox4.Lines)
                    {
                        tw.WriteLine(line);
                    }
                    textBox4.Clear();
                    panel1.Visible = true;
                    panel2.Visible = true;
                    NewStudentPanel.Visible = false;
                    EnrollPanel.Visible = false;
                    ClearNewStudentForm();
                    PopulateStudentList();


                    tw.Close();
                    MessageBox.Show("File Saved Successfully", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                   tw?.Close();
                }
            }

        }
    }
}
