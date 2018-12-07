using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MethodsAndLists.Core.Models;

namespace MethodsAndLists.Core
{
    public class StringToBool
    {
        public bool IsPalindrome(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return false;
            }

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string newWord = new string(charArray);

            if (newWord.ToLower() == word.ToLower())
                return true;
            else
                return false;

        }

        public bool IsZipCode(string input)
        {
            return Regex.IsMatch(input, @"^[1-9]\d\d\s\d\d$");
        }

        public bool IsFiveLettersOrLonger(string word)
        {
            if (word.Length < 5)
            {
                return false;
            }
            else
                return true;
        }
    }

}
