using System;

namespace FirstTest
{
    public class Numbers
    {
        public static void Main(string[] args)
        {
            string numbers = "15";
            try
            {
                SimpleParserTests.TestReturnsZeroWhenEmptyString(numbers);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
