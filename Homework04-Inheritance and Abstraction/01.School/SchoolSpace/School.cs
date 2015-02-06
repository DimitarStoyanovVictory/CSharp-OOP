using System;
using System.Collections.Generic;

namespace SchoolSpace
{
    class School
    {
        public List<Class> Classes { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Discipline> Disciplines { get; set; }
    }
}
