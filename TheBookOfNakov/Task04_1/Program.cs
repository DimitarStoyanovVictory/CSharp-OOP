using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long time = Environment.TickCount;
            DateTime minutes = new DateTime().AddMinutes(time / 1000 / 60);
            DateTime hours = new DateTime().AddHours(time / 1000 / 3600);
            DateTime days = new DateTime().AddDays(time / 1000 / 3600 / 24);
            Console.WriteLine("Time passed from the start of the system : {0}/{1}/{2}", days.Day-1, hours.Hour, minutes.Minute);
        }
    }
}
