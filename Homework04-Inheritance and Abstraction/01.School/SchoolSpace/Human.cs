using System;

namespace SchoolSpace
{
    public abstract class Human
    {
        public Human(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
