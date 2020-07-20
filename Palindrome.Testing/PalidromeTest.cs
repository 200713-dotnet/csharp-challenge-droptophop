using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Testing
{
    public class PalindromeTest
    {
        [Fact]
        public void IsAPalindromeTest()
        {
            var p = new Palindrome();
            var answer = p.IsAPalindrome("racecar");

            AssertTrue(answer);
        }
    }
}