using System;
using System.Collections.Generic;

namespace SchoolSpace   
{
    public class Discipline
    {
        public Discipline(string name, int numberOfLecutres)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLecutres;
        }
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public List<Student> Students { get; set; }
    }
}

