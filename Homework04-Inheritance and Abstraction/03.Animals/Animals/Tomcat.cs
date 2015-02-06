using System;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Genders.Male)
        {
        }
    }
}
