using System.ComponentModel;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        private bool isFormLoaded = false;
        private int selectedRowIndex = -1;
        private BindingList<Student> filteredStudents;
        public Form1()
        {
            InitializeComponent();
            InitializeStudentData();
            PopulateStudentList();

            //Need to set the selection mode to fullrowselect according to microsoft documentation
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Flag to check if form is loaded while testing with message boxes
            isFormLoaded = true;
        }

        public void InitializeStudentData()
        {
            students = new List<Student>
            {
                new Student(1,"John", "Doe", 20, "Male", "1234567890", "john.doe@gmail.com","IT1234","Auckland",true),
                new Student(2, "Jane", "Smith", 24, "Female", "9934567890", "jane.smith@gmail.com","IT1254","Wellington",false),
                new Student(3, "foo", "bar",21, "Other", "1234567890", "foo.bar@gmail.com","IT4234","Christchurch",true),

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
        }
        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string Gender { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string ClassName { get; set; }
            public string Campus { get; set; }
            public bool ExtraMural { get; set; }

            public Student(int id, string firstName, string lastName, int age, string gender, string phoneNumber, string email, string className, string campus, bool extraMural)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Age = age.ToString();
                Gender = gender;
                PhoneNumber = phoneNumber;
                Email = email;
                ClassName = className;
                Campus = campus;
                ExtraMural = extraMural;
            }

            public string FullName => $"{FirstName} {LastName}";
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
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {

                filteredStudents = new BindingList<Student>(students);

            }
            else
            {
                filteredStudents = new BindingList<Student>(students.Where(s => s.FirstName.ToLower().Contains(searchTerm) || s.LastName.ToLower().Contains(searchTerm)).ToList());
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
        }
    }
}
