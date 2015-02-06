using System;
using System.Collections.Generic;
class EnterNumbers
{
    static void Main()
    {
        try
        {
            int[] numbers = new int[10];
            Console.Write("Pleace enter a start number bigger than 1 and smaller than 91, start number: ");
            numbers[0] = int.Parse(Console.ReadLine());
            if (numbers[0] < 1 || numbers[0] > 91) throw new ArgumentOutOfRangeException("Invalid number");
            Console.Write("Pleace enter a end number bigger than 11, bigger than the start number smaller alteast with 10 also it must be less than 100, end number: ");
            numbers[9] = int.Parse(Console.ReadLine());
            if (numbers[0] < 11 || numbers[9] > 99 || numbers[1] + 8 < numbers[1]) throw new ArgumentOutOfRangeException("Invalid number");
            ReadNumber(numbers[0], numbers[9], numbers);

        }
        catch (FormatException)
        {
            throw new FormatException("Pleace enter integer number");
        }
    }

    private static void ReadNumber(int start, int end, int[] numbers)
    {
        for (int i = 1; i < 9; i++)
        {
            Console.Write("Pleace enter new number: ");
            numbers[i] = int.Parse(Console.ReadLine());
            if (numbers[i] >= numbers[9] || numbers[0] > numbers[i]) throw new ArgumentOutOfRangeException("Out of Range pleace enter new numbers");
        }
    }    
}


