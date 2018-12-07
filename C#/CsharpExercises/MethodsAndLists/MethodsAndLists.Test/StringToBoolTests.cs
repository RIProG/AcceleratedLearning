using MethodsAndLists.Core;
using MethodsAndLists.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Test
{
    [TestClass]
    public class StringToBoolTests
    {
        StringToBool x = new StringToBool();

        [TestMethod]
        public void palindrome_should_return_palindrome()
        {
            Assert.IsFalse(x.IsPalindrome(null));
            Assert.IsTrue(x.IsPalindrome("AnnA"));
            Assert.IsFalse(x.IsPalindrome("Greger"));
            Assert.IsTrue(x.IsPalindrome("12321"));
            Assert.IsTrue(x.IsPalindrome("Kalasalak"));
            Assert.IsFalse(x.IsPalindrome("Mamma"));
            Assert.IsTrue(x.IsPalindrome("Alla"));
        }

        [TestMethod]

        public void isZipCode_should_return_if_valid_zipcode_or_not()
        {

            Assert.IsTrue(x.IsZipCode("234 54"));
            Assert.IsFalse(x.IsZipCode("03245"));
            Assert.IsFalse(x.IsZipCode("PANDA"));
            Assert.IsFalse(x.IsZipCode("5 3 2"));
            Assert.IsTrue(x.IsZipCode("444 42"));
        }

        [TestMethod]
        [DataRow("Banan")]
        [DataRow("Roddbåt")]
        [DataRow("Trollkarlar")]
        [DataRow("Filhanteraren")]
        [DataRow("Ögrupp")]

        public void if_word_is_five_letters_or_longer_should_return_true(string word)
        {

            Assert.IsTrue(x.IsFiveLettersOrLonger(word));
        }

        [TestMethod]
        [DataRow("Bana")]
        [DataRow("Rep")]
        [DataRow("Lo")]
        [DataRow("Ö")]
        [DataRow("Man")]

        public void if_word_is_five_letters_or_longer_should_return_false(string word)
        {

            Assert.IsFalse(x.IsFiveLettersOrLonger(word));
        }

        [TestMethod]
        [DataRow (new[] { "Banan", "Roddbåt", "Trollkarlar", "Filhanteraren", "Ögrupp" })]
        public void if_all_words_are_five_letters_or_longer_should_return_true(string[] words)
        {

            Assert.IsTrue(x.IfAllWordsAreFiveLettersOrLonger(words));
            Assert.IsTrue(x.IfAllWordsAreFiveLettersOrLonger_Linq(words));

        }

        [TestMethod]
        [DataRow (new[] { "Bana", "Rep", "Lo", "Man", "Ö" })]
        [DataRow (null)]

        public void if_all_words_are_five_letters_or_longer_should_return_false(string[] words)
        {

            Assert.IsFalse(x.IfAllWordsAreFiveLettersOrLonger(words));
            Assert.IsFalse(x.IfAllWordsAreFiveLettersOrLonger_Linq(words));

        }

    }
}
