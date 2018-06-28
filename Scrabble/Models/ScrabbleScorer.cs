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

        public void CheckScore(string wordString)
        {
            char[] wordArray = StringToArray(StringToLower(wordString));
            foreach(char letter in wordArray)
            {
                if (_worth01.Contains(letter))
                {
                    _score += 1;
                }
            }
        }

        public int GetScore()
        {
            return _score;
        }
    }
}   
