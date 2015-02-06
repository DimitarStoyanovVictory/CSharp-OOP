using System;

namespace HumanStudnetWorker
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHOursPerDay = workHoursPerDay;
        }
        public int MoneyPerHour()
        {
            return (this.WeekSalary / this.WorkHOursPerDay) / 5;
        }
        public int WeekSalary { get; set; }
        public int WorkHOursPerDay { get; set; }
    }
}
