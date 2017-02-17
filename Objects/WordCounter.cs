using System;
using System.Collections.Generic;

namespace WordCounterApp.Objects
{
    public class WordCounter
    {
        private string _longString;
        private string _targetWord;

        public WordCounter(string newLongString)
        {
            _longString = newLongString;
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
