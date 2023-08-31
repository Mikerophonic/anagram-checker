using AnagramChecker.Models;
using System;

namespace AnagramChecker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word: ");
            string referenceWord = Console.ReadLine();

            Console.WriteLine("Enter a list of words: ");
            string listOfWords = Console.ReadLine();

        //    Anagram myAnagram = new Anagram(referenceWord, listOfWords);

        //    myAnagram.Process(); 
            
            //{true, true, true, true, 4/5 characters match}
            // sorted char array of two anagrams are equivalent

            //[d,b,c,a] myArr;  myArr.sort() -> [a,b,c,d]
            // [b,e,a,r,d] [b,r,e,a,d] -> 
            // beardArr.sort() [a,b,d,e,r]
            // breadArr.sort() [a,b,d,e,r] Anagram = same letters
            // beardArr.sort() = breadArr.sort()
            // anagramResult[beardArr] = true;
            // " " = false; otherwise
            //forEach character in word
            // {
            //   if match: +1
            // }

            //{bread, beard, dragon, bard, bowl}
            
        }
    }
}