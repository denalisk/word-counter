using System;
using System.Collections.Generic;

namespace WordCounterApp.Objects
{
    public class WordCounter
    {
        // Class variables
        private string _longString;
        private string _targetWord;
        private string[] _arrayOfWords;

        // Constructor
        public WordCounter(string newLongString)
        {
            _longString = newLongString;
        }

        // Check to see if a given word is the target word
        public bool CheckWord(string word)
        {
            return true;
        }

        // Split the long string of words into separate discreet words by whitespaces
        public void StringSplitter()
        {
            _arrayOfWords = _longString.Split(' ');
        }
        public string[] GetArrayOfWords()
        {
            return _arrayOfWords;
        }

        public string GetLongString()
        {
            return _longString;
        }

        public void SetTargetWord(string newTargetWord)
        {
            _targetWord = newTargetWord;
        }
        public string GetTargetWord()
        {
            return _targetWord;
        }

    } //End Class
} // End Namespace
