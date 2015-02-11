using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year you want to check: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year));
        }
    }
}
