using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] splitedNum = numbers.Split(' ');

            List<int> list = new List<int>();

            foreach (var item in splitedNum)
            {
                list.Add(int.Parse(item));
            }

            long sum = 0;

            foreach (var item in list)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
