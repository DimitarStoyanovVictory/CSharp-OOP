using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_1
{
    public class Teacher
    {
        public static void Main()
        {
            Student st = new Student();
            Student st1 = new Student("Go6o");
            Student st2 = new Student("Pe6o");
            Student st3 = new Student("Dimiar", "Dimitrov", "Stoyanov", "KPTM", "Tu-Sofia", 2, "bo7man@abv.bg", 0884985031);
            Console.WriteLine(Student.NumberOfStudents);
        }
    }
}
