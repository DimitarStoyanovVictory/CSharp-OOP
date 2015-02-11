using Xunit;

namespace Example1.Test
{
    public class ValueTypes
    {
        [Fact]
        public void ShouldAdd()
        {
            //Arange
            var sut = new Calculator();

            //Act  
            var result = sut.Add(10, 10);

            //Asert
            Assert.Equal(20, result);
        }



        [Fact]
        public void ComparingReferenceTypes()
        {
            var p1 = new Person { Name = "Sarah" };
            var p2 = new Person { Name = "Sarah" };

            //Assert.Equal(p1, p2);

            var p3 = p1;

            Assert.Equal(p1, p3);
        }

        [Fact]
        public void ComparingReferenceTypesWithOverriddenEquals()
        {
            var p1 = new PersonWithEquals { Name = "Sarah" };
            var p2 = new PersonWithEquals { Name = "Sarah" };

            Assert.Equal(p1, p2);
        }

        [Fact]
        public void CustomIEqualityComparer()
        {
            var p1 = new PersonWithEquals { Name = "Sarah" };
            var p2 = new PersonWithEquals { Name = "Simon" };

            Assert.Equal(p1, p2, new FirstLetterEqualityComparer());
        }


    }  
}
 