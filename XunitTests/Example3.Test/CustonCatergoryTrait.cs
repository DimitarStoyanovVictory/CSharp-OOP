using Xunit;
using Xunit.Extensions;
using System.Reflection;

namespace Example3.Test
{
    public  class CustonCatergoryTrait
    {
        [Fact]
        [Category("DataLayer")]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        [Category("DataLayer")]
        [SomeTest]
        public void Test2()
        {
            Assert.True(true);
        }

        [Fact]
        [Category("PresntationLayer")]
        [SomeTest]
        public void Test3()
        {
            Assert.True(true);
        }
    }
}
 