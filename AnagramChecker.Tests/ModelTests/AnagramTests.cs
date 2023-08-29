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
          Anagram newAnagram = new Anagram();
          Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
        }
    }
}