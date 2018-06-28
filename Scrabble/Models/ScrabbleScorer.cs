using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble.Models
{
    public class ScrabbleScorer
    {
        private string _wordString;
        private int _score = 0;
        private char[] _worth01 = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
        private char[] _worth02 = {'d', 'g'};
        private char[] _worth03 = {'b', 'c', 'm', 'p'};
        private char[] _worth04 = {'f', 'h', 'v', 'w', 'y'};
        private char[] _worth05 = {'k'};
        private char[] _worth08 = {'j', 'x'};
        private char[] _worth10 = {'q', 'z'};


        public ScrabbleScorer(string wordString = "")
        {
            _wordString = wordString;
        }

        public void SetWordString(string newWordString)
        {
            _wordString = newWordString;
        }

        public string GetWordString()
        {
            return _wordString;
        }

        public string StringToLower(string wordString)
        {
            string wordLower = wordString.ToLower();
            return wordLower;
        }


        public char[] StringToArray(string wordString)
        {
            char[] wordArray = StringToLower(wordString).ToCharArray();
            return wordArray;
        }

        public int CheckScore(string wordString, int newScore)
        {
            newScore = 0;
            char[] wordArray = StringToArray(StringToLower(wordString));
            foreach(char letter in wordArray)
            {
                if (_worth01.Contains(letter))
                {
                    newScore += 1;
                }
                else if (_worth02.Contains(letter))
                {
                    newScore += 2;
                }
                else if (_worth03.Contains(letter))
                {
                    newScore += 3;
                }
                else if (_worth04.Contains(letter))
                {
                    newScore += 4;
                }
                else if (_worth05.Contains(letter))
                {
                    newScore += 5;
                }
                else if (_worth08.Contains(letter))
                {
                    newScore += 8;
                }
                else if (_worth10.Contains(letter))
                {
                    newScore += 10;
                }
            }
            return newScore;
        }

        public void SetScore(int newScore)
        {
            _score = newScore;
        }


        public int GetScore()
        {
            return _score;
        }
    }
}   
