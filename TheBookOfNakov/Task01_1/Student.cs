
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_1
{
    class Student
    {
        
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string university { get; set; }
        public string specialty { get; set; }
        public int course { get; set; }
        public string eMail { get; set; }
        public int phoneNumber { get; set; }

        static int numberOfStudents = 0;

        public static int NumberOfStudents
        {
            get { return Student.numberOfStudents; }
            set { Student.numberOfStudents = value; }
        }
        
        public Student()
        {
        }
        public Student(string firstName, string middleName, string lastName, 
             string university, string specialty, int course, string eMail, int phoneNumber)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;
            numberOfStudents++;
        }

        public Student(string firstName, string lastName, int course, string specialty)
            : this(firstName, null, lastName, null, specialty, course, null, 0)
        {
        }

        public Student(string firstName)
            : this(firstName, null, null, null, null, 0, null, 0)
        {
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("First Name: " + firstName);
            sb.Append(System.Environment.NewLine);
            sb.Append("Middle Name: " + middleName);
            sb.Append(System.Environment.NewLine);
            sb.Append("Last Name: " + lastName);
            sb.Append(System.Environment.NewLine);
            sb.Append("Course: " + course);
            sb.Append(System.Environment.NewLine);
            sb.Append("Specialty: " + specialty);
            sb.Append(System.Environment.NewLine);
            sb.Append("University: " + university);
            sb.Append(System.Environment.NewLine);
            sb.Append("eMail: " + eMail);
            sb.Append(System.Environment.NewLine);
            sb.Append("Phone Number: " + phoneNumber);

            return sb.ToString();
        }
    }
}