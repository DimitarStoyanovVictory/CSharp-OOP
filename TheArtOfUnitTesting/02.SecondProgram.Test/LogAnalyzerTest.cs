using Xunit;

namespace SecondProgram.Test
{
    class LogAnalyzerTest
    {
        [Fact]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            //Arrange
            string fileName = "filewithbadextension.foo";
            LogAnalyzer analyzer = new LogAnalyzer();

            //Act
            bool result = analyzer.IsValidLogFileName(fileName);

            //Assert
            Assert.False(result);
        }
    }
}
