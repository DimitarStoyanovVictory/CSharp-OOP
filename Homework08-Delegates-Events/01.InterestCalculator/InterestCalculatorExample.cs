using System;

namespace InterestCalculator
{
    public class InterestCalculatorExample : InterestCalculator
    {
        public static void Main()
        {
            InterestCalculator compountInterest = new InterestCalculator
                (500, 5.6m, 10, InterestCalculator.GetCompoundInterest);
            Console.WriteLine("{0:F4}", compountInterest.CalcualtedInterest);

            InterestCalculator simpleInterest = new InterestCalculator(2500, 7.2m, 15, GetSimpleInterest);
            Console.WriteLine("{0:F4}", simpleInterest.CalcualtedInterest);
        }
    }
}
