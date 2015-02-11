using Xunit;
using Xunit.Extensions;

namespace Example3.Test
{
    public class InLineTestExample
    {       
        [Theory]
        [InlineData(9, true)]  
        [InlineData(10, false)]
        [InlineData(11, false)]
        [InlineData(-1, true)]
        public void DataDriven(int number, bool expectedResult)
        {
            var obj = new NumberChecker();

            var result = obj.IsLessThenTen(number);

            Assert.Equal(expectedResult, result);
        }
    }
}
