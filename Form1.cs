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
        }
        public void InitializeStudentData()
        {
            students = new List<Student>
            {
                new Student("John", "Doe", 20, "Male", "1234567890", "john.doe@gmail.com","IT1234","Auckland",true),
                new Student("Jane", "Smith", 24, "Female", "9934567890", "jane.smith@gmail.com","IT1254","Wellington",false),
                new Student("foo", "bar",21, "Other", "1234567890", "foo.bar@gmail.com","IT4234","Christchurch",true),

            };
           
        }

        private void PopulateStudentList()
        { 
            dgvStudents.Rows.Clear();
            foreach (var student in students)
            {
                dgvStudents.Rows.Add(student.FullName, student.Email, student.ClassName, student.Campus);
            }
        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string Gender { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string ClassName { get; set; }
            public string Campus { get; set; }
            public bool ExtraMural { get; set; }

            public Student(string firstName, string lastName, int age, string gender, string phoneNumber, string email, string className, string campus, bool extraMural)
            {
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



    }
}
