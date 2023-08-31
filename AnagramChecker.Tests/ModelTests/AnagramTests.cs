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
        public void GetWordListArray_CreateAStringArrayFromUserInput_StringArray() 
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

        [TestMethod]
        public void GetCharArrays_CreatesCharArraysFromUserInputtedWordList_Array()
        {
          string anagramWord = "bread";
          Anagram newAnagram = new Anagram(anagramWord);
          string userWordList = "bread beard butter bear pickle";
          string[] userWordListArray = newAnagram.GetWordListArray(userWordList);
          char[][] charArrays = newAnagram.GetCharArrays(userWordListArray);
          Assert.AreEqual(typeof(char[][]), charArrays.GetType());
        }

        [TestMethod]
        public void SortCharArrays_SortsEachCharArray_Array()
        {
          string anagramWord = "bread";
          Anagram newAnagram = new Anagram(anagramWord);
          string userWordList = "bread beard butter bear pickle";
          string[] userWordListArray = newAnagram.GetWordListArray(userWordList);
          char[][] charArrays = newAnagram.GetCharArrays(userWordListArray);
          char [][] sortedCharArrays = newAnagram.SortCharArrays(charArrays);
          Assert.AreEqual(typeof(char[][]), charArrays.GetType());
        }
    }
}

