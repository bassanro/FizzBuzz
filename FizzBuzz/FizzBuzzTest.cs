using FizzBuzzModels;
using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTest
    {
        // Inital setup to test the test framework 
        // Removed in refactor.
        //[Fact]
        //public void InitalTest()
        //{
        //    Assert.Equal(0,0);
        //}

        [Fact(Skip = "Refactored Code removed")]
        public void Buzz_IntialValue_ReturnsValue()
        {
            //Arrange
            int value = 1;

            //Act
            var result = FizzBuzzDto.GetResult(value);

            //Assert
            Assert.Equal("1", result);
        }

        [Fact(Skip = "Refactored Code removed")]
        public void Buzz_Value3_ReturnsValue()
        {
            int value = 3;
            var result = FizzBuzzDto.GetResult(value);
            Assert.NotNull(result);
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void Buzz_InputValue_ReturnsInput(int input)
        {
            var result = FizzBuzzDto.GetResult(input);
            Assert.NotNull(result);
            Assert.Equal(input.ToString(), result);
        }

        [Theory]
        [InlineData(3)]
        public void Buzz_InputValue3_ReturnsInput(int input)
        {
            var result = FizzBuzzDto.GetResult(input);
            Assert.NotNull(result);
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        public void Buzz_InputValue5_ReturnsInput(int input)
        {
            var result = FizzBuzzDto.GetResult(input);
            Assert.NotNull(result);
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void Buzz_InputValue15_ReturnsInput(int input)
        {
            var result = FizzBuzzDto.GetResult(input);
            Assert.NotNull(result);
            Assert.Equal("FizzBuzz", result);
        }
    }
}
