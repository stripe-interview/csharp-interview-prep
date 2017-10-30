using System;
using Xunit;
using lib;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestJsonNetForSomeReason()
        {
            var class1 = new Class1();
            Assert.NotNull(
                class1.UseJsonNetForSomeReason(
                new
                {
                    Intro = "Hello",
                    Place = "World"
                }
            ));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.True(false);
        }
    }
}
