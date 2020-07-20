using System;
using Xunit;

namespace Palindrome.Domain
{
    class Palindrome
    {
        static void IsAPalindrome(string word)
        {
            char[] ch = word.ToCharArray();
            Array.Reverse(ch);
            string rev = new string(ch);
            bool compare = word.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if(compare)
            {
                Console.WriteLine($"{word} is a Palindrome!");
            } else 
            {
                Console.WriteLine($"{word} is not a Palindrome!");
            }
        }
    }
}