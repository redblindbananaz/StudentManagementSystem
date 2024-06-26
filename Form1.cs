namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        public Form1()
        {
            InitializeComponent();
            InitializeStudentData();
            PopulateStudentList();

            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            isFormLoaded = true;
        }
        private bool isFormLoaded = false;
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
                MessageBox.Show("Selected row count is greater than 0");
                var selectedRow = dgvStudents.SelectedRows[0];
                MessageBox.Show($"Selected row index:{selectedRow}");
                int selectedId = (int)selectedRow.Cells[0].Value;
                var selectedStudent = students.FirstOrDefault(s => s.Id == selectedId);

                if (selectedStudent != null)
                {
                    MessageBox.Show($"Selected Student:{selectedStudent.FirstName}");
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
                    btnDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Selected student is null");
            }
        
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select button clicked");
            dgvStudents_SelectionChanged(sender, e);
        
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



    }
}
