using System;
using System.Collections.Generic;

namespace SchoolSpace
{
    class Details
    {
        public Details(Student students, Class classes, List<Teacher> theachers, List<Discipline> disciplines)
        {
            this.Studnets = students;
            this.Classes = classes;
            this.Teachers = theachers;
            this.Disciplines = disciplines;
        }
        public Student Studnets { get; set; }
        public Class Classes { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Discipline> Disciplines { get; set; }
    }
}
