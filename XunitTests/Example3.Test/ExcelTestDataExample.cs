using Xunit;
using Xunit.Extensions;

namespace Example3.Test
{
    public class ExcelTestDataExample
    {
        [Theory]
        [ExcelData("SampleData.xls", "Select ' from TestData")]
        public void DataDriven3(int number, bool expectedResult)
         {
            var sut = new NumberChecker();

            var result = sut.IsLessThenTen(number);

            Assert.Equal(expectedResult, result);
        }
    }
}
