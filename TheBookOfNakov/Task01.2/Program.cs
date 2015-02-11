using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year you want to check : ");
            int year = int.Parse(Console.ReadLine());
            DateYears checkYear = new DateYears(year);
            Console.WriteLine(checkYear.CheckForLeap(year));
        }
    }
}
