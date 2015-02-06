using System;

namespace Animals
{
    interface ISound
    {
        void ProduceSound();
    }
    abstract class Animal
    {
        public Animal(string name, int age, Genders gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }
        public abstract void ProduceSound();
    }
}
