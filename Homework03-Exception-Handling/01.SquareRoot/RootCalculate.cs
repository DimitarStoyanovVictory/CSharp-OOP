using System;
class RootCalculate
{
    public static double CalculateRootNummber()
    {
        Console.Write("Pleace enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        return Math.Sqrt(number);
    }
}

