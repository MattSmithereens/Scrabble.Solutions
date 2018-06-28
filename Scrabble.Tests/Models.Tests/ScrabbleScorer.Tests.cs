using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Tests
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void GetWordString_ReturnWordString_String()
        {
            //Arrange
            string testString = "cat";
            ScrabbleScorer inputWord = new ScrabbleScorer(testString);

            //Act
            string result = inputWord.GetWordString();

            //Assert
            Assert.AreEqual(testString, result);

        }
    }
}
