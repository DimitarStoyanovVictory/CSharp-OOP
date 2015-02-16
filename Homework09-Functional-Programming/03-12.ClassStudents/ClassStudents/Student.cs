using System.Collections.Generic;

namespace ClassStudents
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, int facultyNumber, string phoneNumber, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}, Age: {2}, Faculty number: {3}, Phone number: {4}, Email: {5}, Group number: {6}",
                    FirstName, LastName, Age, FacultyNumber, PhoneNumber, Email, GroupNumber);
        }
    }
}
