using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(10);
            numbers.Insert(0, 15);
            numbers.Insert(3, 15);
        }
    }
}
