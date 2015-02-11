using System;

namespace GenericList
{
    internal class GenericListExample
    {
        private static void Main()
        {
            var attributes =  new Version(typeof(GenericList<>).GetCustomAttributes(false));
            Console.WriteLine("The GenericList has version {0}.{1}", attributes.Major, attributes.Minor);
            GenericList<int> intList = new GenericList<int>();

            intList.Add(100);
            intList.Add(20);
            intList.Add(10);
            intList.Add(5);

            Console.WriteLine(intList.Count);

            intList.InsertAt(2, 50);
            Console.WriteLine(intList);
            Console.WriteLine(intList.Contains(20));
            Console.WriteLine(intList.Contains(19));
            Console.WriteLine(intList.IndexOf(20));
            Console.WriteLine(intList.IndexOf(19));

            intList.RemoveAt(3);
            Console.WriteLine(intList);
            Console.WriteLine(intList.Min());
            Console.WriteLine(intList.Max());
            intList.Clear();
            Console.WriteLine(intList);

            //Second example

            GenericList<Cat> intList2 = new GenericList<Cat>();
            intList2.Add(new Cat() {Name = "katia"});
            intList2.Add(new Cat() {Name = "Ivana"});
            intList2.Add(new Cat() {Name = "Iva"});
            intList2.Add(new Cat() {Name = "Ivka"});

            Console.WriteLine(intList2.Min());
            Console.WriteLine(intList2.Max());
        }
    }
}