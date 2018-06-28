using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
    public class ScrabbleScorer
    {
        private string _wordString;
        private int _score = 0;
        private char[] _worth01 = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
        private char[] _worth02 = {'d', 'g' };
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

        public char[] StringToArray(string wordString)
        {
            char[] wordArray = wordString.ToCharArray();
            return wordArray;
        }

        public bool CheckDictionary(string wordString)
        {
            char[] wordArray = StringToArray(wordString);
            foreach(char[] letter in wordArray)
                

        }
    }
}   
