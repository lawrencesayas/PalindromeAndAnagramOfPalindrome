using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeAndAnagramOfPalindrome;

namespace UnitTestPalindromeAndAnagramOfPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIdentifyClassificationOfWord_anna_ReturnsTrue()
        {
            Word word = new Word("anna");
            var result = word.IdentifyClassificationOfWord();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIdentifyClassificationOfWord_aaaaaaaa_ReturnsTrue()
        {
            Word word = new Word("aaaaaaaa");
            var result = word.IdentifyClassificationOfWord();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIdentifyClassificationOfWord_aaaaaaaab_ReturnsTrue()
        {
            Word word = new Word("aaaaaaaab");
            var result = word.IdentifyClassificationOfWord();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIdentifyClassificationOfWord_caaaaaaaab_ReturnsFalse()
        {
            Word word = new Word("caaaaaaaab");
            var result = word.IdentifyClassificationOfWord();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestIdentifyClassificationOfWord_donotbobtonod_ReturnsTrue()
        {
            Word word = new Word("donotbobtonod");
            var result = word.IdentifyClassificationOfWord();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestIdentifyClassificationOfWord_owefhijpfwai_ReturnsFalse()
        {
            Word word = new Word("owefhijpfwai");
            var result = word.IdentifyClassificationOfWord();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestIdentifyClassificationOfWord_igdesgide_ReturnsTrue()
        {
            Word word = new Word("igdedgide");
            var result = word.IdentifyClassificationOfWord();

            Assert.AreEqual(true, result);
        }
    }
}
