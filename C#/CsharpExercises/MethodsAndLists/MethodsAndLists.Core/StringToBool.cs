using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MethodsAndLists.Core.Models;
using System.Linq;

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

        public bool IfAllWordsAreFiveLettersOrLonger(string[] words)
        {
            if (words == null)
                return false;

            foreach (string word in words)
            {
                if (word.Length < 5)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IfAllWordsAreFiveLettersOrLonger_Linq(string[] words)
        {
            return (words??new string[] { }).Any(x => x.Count() < 5 ? false : true);
        }
    }

}
