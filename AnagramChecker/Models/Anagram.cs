using System.Collections.Generic;
using System;

namespace AnagramChecker.Models
{
    public class Anagram
    {
      public string AnagramWord { get; set; }
      private string[] wordListArray;

      public Anagram(string anagramWord)
      {
        AnagramWord = anagramWord;
      }

      public char[] GetArray(string anagramWord)
      {
        char[] charArray = anagramWord.ToCharArray();
        return charArray;
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


      
    }

}

