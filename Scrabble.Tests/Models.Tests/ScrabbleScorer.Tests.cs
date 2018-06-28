using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void SetWordString_ReturnNewWordString_String()
        {
            //Arrange
            string testString = "cat";
            ScrabbleScorer inputWord = new ScrabbleScorer(testString);

            //Act
            string newTestString = "dog";
            inputWord.SetWordString(newTestString);
            string result = inputWord.GetWordString();

            //Assert
            Assert.AreEqual(newTestString, result);
        }

        [TestMethod]
        public void StringToLower_ReturnStringLower_String()
        {
            //Arrange
            string testString = "CAT";
            ScrabbleScorer inputWord = new ScrabbleScorer(testString);

            //Act
            string lowerTest = "cat";
            string result = inputWord.StringToLower(testString);
            //char[] testArray = { 'c', 'a', 't' };
            //char[] charArray = inputWord.StringToArray(inputWord.GetWordString());

            //Assert
            Assert.AreEqual(lowerTest, result);
        }

        [TestMethod]
        public void StringToArray_ReturnStringArray_Char()
        {
            //Arrange
            string testString = "cat";
            ScrabbleScorer inputWord = new ScrabbleScorer(testString);

            //Act
            char[] testArray = { 'c', 'a', 't' };
            char[] result = inputWord.StringToArray(inputWord.GetWordString());

            //Assert
            CollectionAssert.AreEqual(testArray, result);

        }

        [TestMethod]
        public void GetScore_ReturnScore_Int()
        {
            //Arrange
            ScrabbleScorer initialScore = new ScrabbleScorer();

            //Act
            int result = initialScore.GetScore();

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CheckScore_ReturnScoreSum_Int()
        {
            //Arrange
            string testString = "cat";
            int testScore = 0;
            ScrabbleScorer inputWord = new ScrabbleScorer(testString);

            //Act
            string gotWord = inputWord.GetWordString();
            int finalScore = inputWord.CheckScore(gotWord, testScore);
            inputWord.SetScore(finalScore);
            int result = inputWord.GetScore();
            Console.WriteLine(result);



            //Assert
            Assert.AreEqual(5, result);
        }
    }
}