using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;
using System.Collections.Generic;
using System;

namespace AnagramChecker.Test
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
        {
          Anagram newAnagram = new Anagram("bread");
          Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
        }
        [TestMethod]
        public void GetAnagramWord_ReturnsAnagramWord_String()
        {
          string anagramWord = "bread";
          Anagram newAnagram = new Anagram(anagramWord);
          string result = newAnagram.AnagramWord;
          Assert.AreEqual(anagramWord, result);
        }

        [TestMethod]
        public void GetWordListArray_CreateAStringArrayFromUserInpuStringArray() 
        {
          string anagramWord = "bread";
          Anagram newAnagram = new Anagram(anagramWord);
          string userWordList = "bread beard butter bear pickle";
          string[] userWordListArray = newAnagram.GetWordListArray(userWordList);
          Assert.AreEqual(typeof(string[]), userWordListArray.GetType());
        }


        [TestMethod]
        public void GetArray_CreatesArrayOfAnagramWord_Array()
        {
          string anagramWord = "bread";
          Anagram newAnagram = new Anagram(anagramWord);
          char[] anagramArray = newAnagram.GetArray(anagramWord);
          Assert.AreEqual(typeof(char[]), anagramArray.GetType());
        }
    }
}

