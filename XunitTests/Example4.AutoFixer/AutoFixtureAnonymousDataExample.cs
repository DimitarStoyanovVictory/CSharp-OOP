﻿using Xunit;
using Ploeh.AutoFixture;

namespace Example4.AutoFixer
{
    public class AutoFixtureAnonymousDataExample
    {
        [Fact]
        static void TestWithHardCreatedString()
        {
            var inputString = "hello";

            var sut = new StringUnits();

            var result = sut.MakeUpper(inputString);

            Assert.Equal("HELLO", result);
        }

        [Fact]
        public void TestWithAutogeneratedString()
         {
            var fixture = new Fixture();

            var inputString = fixture.Create<string>("sarah");
 
            var sut = new StringUnits();

            var result = sut.MakeUpper(inputString);

            Assert.Equal(inputString.ToUpper(), result); 
        }

        [Fact]
        public void AutogeneratingComplexTypes()
        {
            var fixture = new Fixture();

            var sut = fixture.Create<Person>();
        }

        [Fact]
        public void AutogeneratingSequace()
        {
            var fixture = new Fixture();

            var names = fixture.CreateMany<string>();
            var tenNames = fixture.CreateMany<string>(10);

            var ages = fixture.CreateMany<int>();
            var tenAges = fixture.CreateMany<int>(10);

            var tenPeople = fixture.CreateMany<Person>(10);
        }
    }
}
