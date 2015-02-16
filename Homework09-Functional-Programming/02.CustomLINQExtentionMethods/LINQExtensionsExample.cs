using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomLINQExtentionMethods
{
    public class LINQExtensionsExample
    {
        static void Main()
        {
            // WhereNot extension method example

            List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            ints = ints.WhereNot(x => x > 3).ToList();

            ints.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            // Repeat extension method

            ints = ints.Repeat(3).ToList();
            ints.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            // WhereNotExtensionMethod

            List<string> strings = new List<string>() {"Dimitar", "Ognyan", "Angel", "Kiril", "Bilyana"};
            List<string> suffixes = new List<string>() { "tar", "yan", "bar", "var"};

            strings.WhereEndsWith(suffixes).ToList().ForEach(name => Console.WriteLine(name));
        }
    }
}

