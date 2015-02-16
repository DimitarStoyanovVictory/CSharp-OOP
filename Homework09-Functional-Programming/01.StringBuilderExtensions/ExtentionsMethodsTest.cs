using System;
using System.Collections.Generic;
using System.Text;
using StringBuilderExtensions;

namespace TestExtensions
{
    class ExtentionsMethodsTest
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder("Bilyana");

            Console.WriteLine(text.Substring(4, 3)); // ana 
            Console.WriteLine(text.RemoveText("Bil")); // yana
            
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5};
            Console.WriteLine(text.AppendAll(ints)); // yana12345
        }
    }
}
