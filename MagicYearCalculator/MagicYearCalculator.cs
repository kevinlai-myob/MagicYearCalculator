using System;

namespace MagicYearCalculatorTests
{
    public class MagicYearCalculator
    {
        public string GetFullname(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public double GetMonthlySalary(double annualSalary)
        {
            return Math.Floor(annualSalary / 12);
        }

        public double GetMagicYear(double magicYear)
        {
            return magicYear + 65;
        }
    }
}