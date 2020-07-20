using FizzBuzz.Source;
using FluentAssertions;
using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzCalculatorTests
    {
        private FizzBuzzCalculator _sut;

        public FizzBuzzCalculatorTests()
        {
            _sut = new FizzBuzzCalculator();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Calculate_GivenNumberNonDivisibleBy3Or5_ReturnsNumber(int number)
        {
            var result = _sut.Calculate(number);

            result.Should().Be(number.ToString());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        public void Calculate_GivenNumberDivisibleBy3_ReturnsFizz(int number)
        {
            const string expected = "Fizz";

            var result = _sut.Calculate(number);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Calculate_GivenNumberDivisibleBy5_ReturnsBuzz(int number)
        {
            const string expected = "Buzz";

            var result = _sut.Calculate(number);

            result.Should().Be(expected);
        }

        [Fact]
        public void Calculate_GivenNumberDivisibleBy3And5_ReturnsFizzBuzz()
        {
            const string expected = "FizzBuzz";

            var result = _sut.Calculate(15);

            result.Should().Be(expected);
        }
    }
}
