using AnagramChecker.Models;
using System;
using System.Collections.Generic;


namespace AnagramChecker
{
    class Program
    {
        static List<bool> Process(Anagram newAnagram)
        {
          char[] anagramArray = newAnagram.GetArray(newAnagram.AnagramWord);
          Array.Sort(anagramArray);
          string[] userWordListArray = newAnagram.GetWordListArray(newAnagram.UserWordList);
          char[][] charArrays = newAnagram.GetCharArrays(userWordListArray);
          char [][] sortedCharArrays = newAnagram.SortCharArrays(charArrays);
          List<bool> comparisonResults = newAnagram.CompareToBaseWord(sortedCharArrays, anagramArray);
          Console.WriteLine(string.Join(", ", comparisonResults));
          return comparisonResults;
        }

        static void Main()
        {
            Console.WriteLine("Enter a word: ");
            string baseWord = Console.ReadLine();

            Console.WriteLine("Enter a list of words separated by a space: ");
            string userWordList = Console.ReadLine();

            Anagram newAnagram = new Anagram(baseWord, userWordList);

            List<bool> comparisonResults = Process(newAnagram);

            for (int i = 0; i < comparisonResults.Count; i++)
            {
                string resultText = comparisonResults[i] ? "is" : "is not";
                // Console.WriteLine($"Word '{newAnagram.UserWordListArray[i]}' {resultText} an anagram.");
                Console.WriteLine($"Word '{newAnagram.GetWordListArray(newAnagram.UserWordList)[i]}' {resultText} an anagram of '{baseWord}'");
            }

            
        }
    }
}