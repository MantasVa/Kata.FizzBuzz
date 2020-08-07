using Kata.FizzBuzz.Infrastructure.Factory;
using Kata.FizzBuzz.Infrastructure.Strategy;
using System;
using Xunit;

namespace Kata.FizzBuzz.Tests
{
    public class FizzBuzzGameTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(14)]
        [InlineData(44)]
        public void GetFizzBuzzOutput_ThreeDividerChangedToFizz(int arrayIndex)
        {
            var game = new GameFactory().CreateGameRules();
            string[] output = game.GetGameOutput();

            Assert.Equal("Fizz", output[arrayIndex]);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(9)]
        [InlineData(49)]
        [InlineData(64)]
        public void GetFizzBuzzOutput_FiveDividerChangedToBuzz(int arrayIndex)
        {
            var game = new GameFactory().CreateGameRules();
            string[] output = game.GetGameOutput();

            Assert.Equal("Buzz", output[arrayIndex]);
        }

        [Theory]
        [InlineData(14)]
        [InlineData(59)]
        [InlineData(29)]
        [InlineData(89)]
        public void GetFizzBuzzOutput_ThreeFiveDividerChangedToFizzBuzz(int arrayIndex)
        {
            var game = new GameFactory().CreateGameRules("FizzBuzz");
            string[] output = game.GetGameOutput();

            Assert.Equal("FizzBuzz", output[arrayIndex]);
        }

        [Theory]
        [InlineData(48)]
        [InlineData(6)]
        [InlineData(13)]
        [InlineData(20)]
        public void GetFizzBuzzOutput_SevenDividerChangedToWhizz(int arrayIndex)
        {
            var game = new GameFactory().CreateGameRules("Whizz");
            string[] output = game.GetGameOutput();

            Assert.Equal("Whizz", output[arrayIndex]);
        }
    }
}
