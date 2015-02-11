using System;

namespace Task02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = int.Parse(Console.ReadLine());
            int maxValue = int.Parse(Console.ReadLine())+1;
            Random randomNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(randomNumber.Next(minValue, maxValue) + " ");   
            }
        }
    }
}
