using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyFirstUWPTests
{
    public class Other
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, 4);
        }


        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        [Theory]
        [InlineData(3, 2.5)]
        public void AnotherTheory(int x, float m)
        {
            float j = (float)x;
            m += x;

            Assert.True(m < 6); 
        }

    }
}
