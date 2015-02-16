using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ClassStudents;

namespace StudnetExample
{
    public class Example
    {
        static void Main()
        {
            // Problem 4.Students by Group

            List<Student> students = new List<Student>()
            {
                new Student("Dimitar", "Stoyanov", 25, 251314021, "+359 2988846601", "Dimitar.Stoyanov@abv.bg", new List<int>() { 5, 5, 2, 2}, 2),
                new Student("Ognyan", "Dimitrov", 30, 251209001, "+3592876999999", "Ognyan.Dimitrov@yahooo.com", new List<int>() { 6, 6, 6, 6}, 4),
                new Student("Dominik", "Stoyanov", 24, 251313001, "02988846623", "Dominik.Stoyanov@gamil.com", new List<int>() { 5, 5, 6, 2}, 3),
                new Student("Angel", "Kostadinov", 27, 251313026, "0877123456", "Angel.Kostadinov@abv.bg", new List<int>() { 6, 5, 5, 6}, 2),
            };

            var studentsFromGroupTwo =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            studentsFromGroupTwo.ToList().ForEach(student => Console.WriteLine("Name: {0}, Group: {1}", student.FirstName, student.GroupNumber));

            // Problem 5.Students by First and Last Name
            Console.WriteLine();

            var studentsWithBiggerFirstname =
                from student in students
                where string.Compare(student.FirstName, student.LastName) < 0
                select student;

            studentsWithBiggerFirstname.ToList().ForEach(student => Console.WriteLine("Name: {0}, Surname: {1}", student.FirstName, student.LastName));

            // Problem 6.Students by Age
            Console.WriteLine();

            var studentsWithCurrentAge =
                from student in students
                where student.Age > 17 && student.Age < 25
                select student;

            studentsWithCurrentAge.ToList().ForEach(student => Console.WriteLine("Name: {0}, Surname: {1}, Age: {2}", student.FirstName, student.LastName, student.Age));

            // Problem 7.Sort Students
            Console.WriteLine();

            // Problem 7 with lambda expressions

            var sortStudents = students;
            sortStudents = sortStudents.OrderBy(student => student.FirstName).ThenBy(student => student.LastName).Reverse().ToList();

            sortStudents.ForEach(student => Console.WriteLine("Name: {0}, Surname: {1}", student.FirstName, student.LastName));

            // Problem 7 with LINQ query
            Console.WriteLine();

            var sortStudentsWithQuery =
                from student in students
                orderby student.FirstName descending, student.LastName descending 
                select student;

            sortStudentsWithQuery.ToList().ToList().ForEach(student => Console.WriteLine("Name: {0}, Surname: {1}", student.FirstName, student.LastName));

            // Problem 8.Filter Students by Email Domain
            Console.WriteLine();

            var filterStudentsByEmail =
                from student in students
                where student.Email.EndsWith("@abv.bg")
                select student;

            filterStudentsByEmail.ToList().ForEach(student => Console.WriteLine("Name: {0}, Surname: {1}, Email: {2}", student.FirstName, student.LastName, student.Email));

            // Problem 9.Filter Students by Phone
            Console.WriteLine();

            var studentsWithPhoneNumbersInSofia =
                from student in students
                where Regex.Match(student.PhoneNumber, @"\+3592|02|\+359 2").Success == true
                select student;

            studentsWithPhoneNumbersInSofia.ToList().ForEach(student => Console.WriteLine("Name: {0}, Surname: {1}, Phone number: {2}", student.FirstName, student.LastName, student.PhoneNumber));

            // Problem 10.Excellent Students
            Console.WriteLine();

            var studentsWithExellentMarks =
                from student in students
                where student.Marks.Contains(6) == true
                select new { FullName = student.FirstName + " " + student.LastName, StudentMarks = student.Marks };

  
            foreach (var student in studentsWithExellentMarks)
            {
                string marks = string.Join(", ", student.StudentMarks);
                Console.WriteLine("FullName: {0}, Marks: {1}", student.FullName, marks);
            }

            // Problem 11.Weak Students
            Console.WriteLine();

            var studentsWithWeakMarks =
                from student in students
                where student.Marks.FindAll(mark => mark == 2).Count > 1
                select new { FullName = student.FirstName + " " + student.LastName, StudentMarks = student.Marks }; ;

            foreach (var student in studentsWithWeakMarks)
            {
                string marks = string.Join(", ", student.StudentMarks);
                Console.WriteLine("Full name: {0}, Marks: {1}", student.FullName, marks);
            }

            // Problem 12.Students Enrolled in 2014
            Console.WriteLine();

            var studentsFrom2014 =
                from student in students
                where student.FacultyNumber.ToString().Substring(4, 2) == "14"
                select student;

            foreach (var student in studentsFrom2014)
            {
                string marks = string.Join(", ", student.Marks);
                Console.WriteLine("Full name: {0} {1}, Marks: {2}", student.FirstName, student.LastName, marks);
            }
        }
    }
}
