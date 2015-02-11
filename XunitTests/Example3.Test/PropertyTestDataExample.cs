using System;
using Xunit;
using Xunit.Extensions;

namespace Example3.Test
{
    public class PropertyTestDataExample
    {
        [Theory]
        [PropertyData("TestData", PropertyType=typeof(PropertyTestDataSource))]
        public void DataDriven2(int number, bool expectedResult)
        {
            var sut = new NumberChecker();

            var result = sut.IsLessThenTen(number);

            Assert.Equal(expectedResult, result);
        }
    }
}
