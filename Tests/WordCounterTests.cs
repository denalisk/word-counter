using Xunit;
using System.Collections.Generic;

namespace WordCounterApp.Objects
{
    public class WordCounterTest
    {
        [Fact]
        public void WordCounterConstructor_GetSetLongString_LongString()
        {
            // Arrange
            string newLongString = "This is a string";
            // Act
            WordCounter newWordCounter = new WordCounter(newLongString);
            // Assert
            Assert.Equal(newLongString, newWordCounter.GetLongString());
        }

        [Fact]
        public void WordCounterConstructor_GetSetTargetWord_TargetWord()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            WordCounter newWordCounter = new WordCounter(newLongString);
            // Act
            newWordCounter.SetTargetWord(newTargetWord);
            // Assert
            Assert.Equal(newTargetWord, newWordCounter.GetTargetWord());
        }

        [Fact]
        public void WordLister_Split_LongStringSplit()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            WordCounter newWordCounter = new WordCounter(newLongString);
            List<string> resultsList = new List<string> {"This", "is", "a", "string"};
            // Act
            newWordCounter.StringSplitter()
            // Assert
            for (int i = 0; i < newWordCounter.GetWordList().Count; i++)
            {
                Assert.Equal(resultsList[i], newWordCounter.GetWordList()[i]);
            }
        }
    }
}
