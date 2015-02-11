using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;
using Example5;

namespace Example5.AutoFixerDataTheories.Test
{
    public class AutoFixerDataTheories
    {
        [Theory]
        [AutoData()]
        public void SingleAutoData(int number1, int number2)
        {
            var sut = new Calculator();

            var result = sut.Add(number1, number2);

            Assert.Equal(number1 + number2, result);
        }

        [Theory]
        [InlineAutoData(42)]
        [InlineAutoData]
        public void inlineAutoData(int number1, int number2)
        {
            var sut = new Calculator();

            var result = sut.Add(number1, number2);

            Assert.Equal(number1 + number2, result);
        }
    }
}
