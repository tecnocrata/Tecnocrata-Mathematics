using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tx.Math.Combinatory;

namespace AnagramLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyString()
        {
            string word = "";
            List<string> anagrams = Anagram.MakeAnagrams(word);
            Assert.IsNotNull(anagrams);
            Assert.AreEqual(0, anagrams.Count);
        }

        [TestMethod]
        public void StringWithSpaces()
        {
            string word = "a ";
            List<string> anagrams = Anagram.MakeAnagrams(word);
            Assert.AreEqual(2, anagrams.Count);

            Assert.AreEqual("a ", anagrams[0]);
            Assert.AreEqual(" a", anagrams[1]);
        }

        [TestMethod]
        public void SimpleCharacter()
        {
            string word = "a";
            List<string> anagrams = Anagram.MakeAnagrams(word);

            Assert.AreEqual(1, anagrams.Count);
            Assert.AreEqual(word, anagrams[0]);
        }

        [TestMethod]
        public void Verify_With_TwoCharacters()
        {
            string word = "ab";
            List<string> anagrams = Anagram.MakeAnagrams(word);
            Assert.AreEqual(2, anagrams.Count);
            Assert.AreEqual("ab", anagrams[0]);
            Assert.AreEqual("ba", anagrams[1]);
        }

        [TestMethod]
        public void Verify_With_ThreeCharacters()
        {
            string word = "abc";
            List<string> anagrams = Anagram.MakeAnagrams(word);
            Assert.AreEqual(6, anagrams.Count);
            Assert.AreEqual("abc", anagrams[0]);
            Assert.AreEqual("acb", anagrams[1]);
            Assert.AreEqual("bac", anagrams[2]);
            Assert.AreEqual("bca", anagrams[3]);
            Assert.AreEqual("cab", anagrams[4]);
            Assert.AreEqual("cba", anagrams[5]);
        }

        [TestMethod]
        public void Verify_With_FourCharacters()
        {
            string word = "abcd";
            List<string> anagrams = Anagram.MakeAnagrams(word);
            Assert.AreEqual(24, anagrams.Count);
            Assert.AreEqual("abcd", anagrams[0]);
            Assert.AreEqual("abdc", anagrams[1]);
            Assert.AreEqual("acbd", anagrams[2]);
            Assert.AreEqual("acdb", anagrams[3]);
            Assert.AreEqual("adbc", anagrams[4]);
            Assert.AreEqual("adcb", anagrams[5]);
            Assert.AreEqual("bacd", anagrams[6]);
            Assert.AreEqual("badc", anagrams[7]);
            Assert.AreEqual("bcad", anagrams[8]);
            Assert.AreEqual("bcda", anagrams[9]);
            Assert.AreEqual("bdac", anagrams[10]);
            Assert.AreEqual("bdca", anagrams[11]);
            Assert.AreEqual("cabd", anagrams[12]);
            Assert.AreEqual("cadb", anagrams[13]);
            Assert.AreEqual("cbad", anagrams[14]);
            Assert.AreEqual("cbda", anagrams[15]);
            Assert.AreEqual("cdab", anagrams[16]);
            Assert.AreEqual("cdba", anagrams[17]);
            Assert.AreEqual("dabc", anagrams[18]);
            Assert.AreEqual("dacb", anagrams[19]);
            Assert.AreEqual("dbac", anagrams[20]);
            Assert.AreEqual("dbca", anagrams[21]);
            Assert.AreEqual("dcab", anagrams[22]);
            Assert.AreEqual("dcba", anagrams[23]);
        }

        [TestMethod]
        public void Verify_With_FiveCharacters()
        {
            string word = "abcde";
            List<string> anagrams = Anagram.MakeAnagrams(word);
            Assert.AreEqual(120, anagrams.Count);
        }

        [TestMethod]
        public void Verify_With_biro()
        {
            string word = "biro";
            List<string> anagrams = Anagram.MakeAnagrams(word);
            Assert.AreEqual(24, anagrams.Count);
            Assert.AreEqual("biro", anagrams[0]);
            Assert.AreEqual("bior", anagrams[1]);
            Assert.AreEqual("brio", anagrams[2]);
            Assert.AreEqual("broi", anagrams[3]);
            Assert.AreEqual("boir", anagrams[4]);
            Assert.AreEqual("bori", anagrams[5]);
            Assert.AreEqual("ibro", anagrams[6]);
            Assert.AreEqual("ibor", anagrams[7]);
            Assert.AreEqual("irbo", anagrams[8]);
            Assert.AreEqual("irob", anagrams[9]);
            Assert.AreEqual("iobr", anagrams[10]);
            Assert.AreEqual("iorb", anagrams[11]);
            Assert.AreEqual("rbio", anagrams[12]);
            Assert.AreEqual("rboi", anagrams[13]);
            Assert.AreEqual("ribo", anagrams[14]);
            Assert.AreEqual("riob", anagrams[15]);
            Assert.AreEqual("robi", anagrams[16]);
            Assert.AreEqual("roib", anagrams[17]);
            Assert.AreEqual("obir", anagrams[18]);
            Assert.AreEqual("obri", anagrams[19]);
            Assert.AreEqual("oibr", anagrams[20]);
            Assert.AreEqual("oirb", anagrams[21]);
            Assert.AreEqual("orbi", anagrams[22]);
            Assert.AreEqual("orib", anagrams[23]);
        }
    }
}
