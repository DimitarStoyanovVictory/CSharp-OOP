using System;
class ExceptionHandler
{
    static void Main()
    {
        try
        {
            Console.WriteLine(RootCalculate.CalculateRootNummber()); 
        }
        catch (OverflowException)
        {
            throw new ArgumentException("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
