using System;
using System.Collections.Generic;

namespace WordCounterApp.Objects
{
    public class WordCounter
    {
        private string _longString;
        private string _targetWord;
        private string[] _arrayOfWords;

        public WordCounter(string newLongString)
        {
            _longString = newLongString;
        }

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

    }
}
