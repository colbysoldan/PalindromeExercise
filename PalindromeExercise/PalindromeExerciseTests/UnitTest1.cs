using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("car", false)]
        [InlineData("asdfgfdsa", true)]

        public void PalindromeTest(string word, bool expected)
        {
            //Arrange
            var test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
