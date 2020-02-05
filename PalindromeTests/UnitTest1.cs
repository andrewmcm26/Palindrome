using System;
using System.Linq;
using Palindrome;
using Xunit;

namespace PalindromeTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData ("racecar", true)]
        [InlineData ("month", false)]
        [InlineData ("a", true)]
        [InlineData ("", true)]

        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
