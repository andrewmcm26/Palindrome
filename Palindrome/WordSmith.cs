using System;
using System.Linq;
namespace Palindrome

{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string word)
        {
            //var ch = word.ToArray();
            //Array.Reverse(ch);
            //var rev = new string (ch);
            //return word == rev;

            return word.SequenceEqual(word.Reverse());

        }
    }
}
