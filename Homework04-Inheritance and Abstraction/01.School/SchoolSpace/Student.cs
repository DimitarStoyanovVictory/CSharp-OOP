namespace SchoolSpace
{
    public class Student : Human
    {
        public Student(string name, int uniqueClassNumber)
            : base(name)
        {
            this.Name = name;
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public int UniqueClassNumber { get; set; }
    }
}

