using System;
using Xunit;

namespace Classes_Testing.TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DivdeTest()
        {
            double num1 = 1;
            double num2 = 3;
            double expectedResult = 0.3333;

            double result = Program.Divide(num1, num2);

            Assert.Equal(expectedResult, result, 4);
        }
    }
}
