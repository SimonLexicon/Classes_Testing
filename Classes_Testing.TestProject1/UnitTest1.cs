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

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(9, 3, 3)]
        [InlineData(88, 52, 1.7)]
        [InlineData(155, 100, 1.6)]
        [InlineData(99999, 652, 153.4)]
        public void DivideTestTheory(double num1, double num2, double expected)
        {
            double result = Program.Divide(num1, num2);
            Assert.Equal(expected, result, 1);
        }

        [Fact]
        public void Divde_by_zero_Test()
        {
            double num1 = 1;
            double num2 = 0;
            var expectedResult = Assert.Throws<DivideByZeroException>(
                () => Program.Divide(num1, num2));

            Assert.Equal("Can't divide by 0.", expectedResult.Message);
        }

        [Fact]
        public void DivdeInt_by_zero_Test()
        {
            int num1 = 1;
            int num2 = 0;
            var expectedResult = Assert.Throws<DivideByZeroException>(
                () => Program.DivideInt(num1, num2));

            Assert.Equal("Attempted to divide by zero.", expectedResult.Message);
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5}, 15)]
        [InlineData(new double[] { double.PositiveInfinity, 10, double.NegativeInfinity }, double.NaN)]
        public void Add_Test(double[] nums, double expected)
        {
            double result = Program.Add(nums);
            Assert.Equal(expected, result);
        }
    }
}
