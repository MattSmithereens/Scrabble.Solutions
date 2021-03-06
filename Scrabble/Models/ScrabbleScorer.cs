﻿using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
    public class ScrabbleScorer
    {
        private string _wordString;
        private List<int> scrabbleValue = new List<int> { } ;
        private static Dictionary<char, int> _scrabbleValues = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 3 }, { 'c', 3 }, { 'd', 2 }, { 'e', 1 }, { 'f', 4 }, { 'g', 2 }, { 'h', 4 }, { 'i', 1 }, { 'j', 8 }, { 'k', 5 }, { 'l', 1 }, { 'm', 3 }, { 'n', 1 }, { 'o', 1 }, { 'p', 3 }, { 'q', 10 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 }, { 'v', 4 }, { 'w', 4 }, { 'x', 8 }, { 'y', 4 }, { 'z', 10 } };


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
