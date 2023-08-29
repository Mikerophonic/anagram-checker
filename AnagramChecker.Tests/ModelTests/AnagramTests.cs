using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;
using System.Collections.Generic;
using System;

namespace AnagramChecker.TestTools
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
        public void MakeList_CreatesInstanceofList_List()
        {
          List<string> expected = new List<string> { "beard" };
          Assert.AreEqual(typeof(List<string>), expected.GetType());
        }
        [TestMethod]
        public void GetArray_CreatesArrayOfAnagramWord_Array()
        {
          string anagramWord = "bread";
          char[] anagramArray = GetArray(anagramWord);
          Assert.AreEqual(typeof(Array), anagramArray.GetType());

          
        }
    }
}

