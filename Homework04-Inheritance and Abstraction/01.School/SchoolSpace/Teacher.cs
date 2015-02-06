using System.Collections.Generic;

namespace SchoolSpace
{
    public class Teacher : Human // IS A
    {
        public Teacher(string name)
            : base(name)
        {
            this.Name = name;
        }
        public List<Discipline> Disciplines { get; set; }
    }
}
