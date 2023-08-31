using System.Collections.Generic;
using System.Linq;
using System;

namespace AnagramChecker.Models
{
    public class Anagram
    {
      public string AnagramWord { get; set; }
      // private string[] wordListArray;
      public string UserWordList { get; set; }

      public Anagram(string anagramWord, string userWordList)
      {
        AnagramWord = anagramWord;
        UserWordList = userWordList;
      }

      public char[] GetArray(string anagramWord)
      {
        char[] baseWordCharArray = anagramWord.ToCharArray();
        return baseWordCharArray;
      }

      public string[] GetWordListArray(string input)
      {
        string[] wordListArray = input.ToLower().Split(" ");
        return wordListArray;
      }

      public char[][] GetCharArrays(string[] wordListArray)
      {
        char[][] charArrays = new char[wordListArray.Length][];

        for (int i = 0; i < wordListArray.Length; i++)
        {
            charArrays[i] = wordListArray[i].ToCharArray();
        }

        return charArrays;
      }

      public char[][] SortCharArrays(char[][] charArrays)
      {
        foreach (char[] charArray in charArrays)
        {
            Array.Sort(charArray);
        }
        return charArrays;
      }

      public List<bool> CompareToBaseWord(char[][] charArrays, char[] baseWordCharArray)
      {
          List<bool> comparisonResults = new List<bool>();
          for (int i = 0; i < charArrays.Length; i++)
          {
            bool isSameAsBase = charArrays[i].SequenceEqual(baseWordCharArray);              comparisonResults.Add(isSameAsBase);
          }
          return comparisonResults;
      }

    }
}

