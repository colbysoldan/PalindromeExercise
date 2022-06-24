using System;

namespace PalindromeExercise
{
    public class WordSmith
    { 

        public bool IsAPalindrome(string word)
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            var reverse = new string(arr);

            return word == reverse;

        }
    }
}

