using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
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
}
