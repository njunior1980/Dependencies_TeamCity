using CalculatorLib;

namespace CalculatorTests
{
    using Xunit;

    public class CalcTests
    {
        [Fact]
        public void Sum_Two_Numbers()
        {
            // arrange
            var calc = new Calculator();

            var num1 = 2;
            var num2 = 2;
            var expected = 4;

            // act
            var result = calc.Sum(num1, num2);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtract_Two_Numbers()
        {
            // arrange
            var calc = new Calculator();

            var num1 = 2;
            var num2 = 2;
            var expected = 0;

            // act
            var result = calc.Subtract(num1, num2);

            // assert
            Assert.Equal(expected, result);
            Assert.True(result == 0);
        }

        [Fact]
        public void Multiply_Two_Numbers()
        {
            // arrange
            var calc = new Calculator();

            var num1 = 6;
            var num2 = 2;
            var expected = 12;
            var invalidValue = 13;

            // act
            var result = calc.Multiply(num1, num2);

            // assert
            Assert.Equal(expected, result);
            Assert.NotEqual(invalidValue, result);
        }

        [Fact]
        public void Divide_Two_Numbers()
        {
            // arrange
            var calc = new Calculator();

            var num1 = 10;
            var num2 = 5;
            var expected = 2;

            // act
            var result = calc.Divide(num1, num2);

            // assert
            Assert.Equal(expected, result);
            Assert.True(result > 0);
        }
    }
}
