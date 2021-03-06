﻿using System;
    
namespace InterestCalculator2
{
    public class InterestCalculator
    {
        public InterestCalculator()
        {
        }

        public InterestCalculator(decimal money, decimal interest, int years, Func<decimal, decimal, int, decimal> calculateInterest)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.CalcualtedInterest = calculateInterest(money, interest, years);
        }

        public decimal Money { get; set; }

        public decimal Interest { get; set; }

        public int Years { get; set; }

        public decimal CalcualtedInterest { get; set; }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum * (1 + ((interest / 100) * years));
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + ((interest / 100) / 12)), (double)(years * 12));
        }
    }
}
