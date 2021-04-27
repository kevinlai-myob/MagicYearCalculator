using Xunit;

namespace MagicYearCalculatorTests
{
    public class MagicYearCalculatorShould
    {   
        [Fact]
        public void GetFullname()
        {
            var calculator = new MagicYearCalculator();
            var fullname = calculator.GetFullname("John", "Doe");
            
            Assert.Equal("John Doe", fullname);
        }
        [Fact]
        public void GetMonthlySalary()
        {
            var calculator = new MagicYearCalculator();
            var monthlySalary = calculator.GetMonthlySalary(80000);
            
            Assert.Equal(6666, monthlySalary);
        }
        [Fact]
        public void GetMagicYear()
        {
            var calculator = new MagicYearCalculator();
            var magicYear = calculator.GetMagicYear(2000);
            
            Assert.Equal(2065, magicYear);
        }

    }
}