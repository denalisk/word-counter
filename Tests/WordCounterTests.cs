using Xunit;
using System.Collections.Generic;

namespace WordCounterApp.Objects
{
    public class WordCounterTest
    {
        [Fact]
        // test if the program can successfully grab the large string input from the user
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
        // test to see if the program can grab the target word input from the user successfully
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
        // test if the program can successfully break the large string into discreet segments
        public void WordLister_Split_LongStringSplit()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            WordCounter newWordCounter = new WordCounter(newLongString);
            string[] resultsList = new string[] {"This", "is", "a", "string"};
            // Act
            newWordCounter.StringSplitter();
            // Assert
            for (int i = 0; i < newWordCounter.GetArrayOfWords().Length; i++)
            {
                Assert.Equal(resultsList[i], newWordCounter.GetArrayOfWords()[i]);
            }
        }

        [Fact]
        // test if the program can check target word against others
        public void WordLister_Split_LongStringSplit()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            WordCounter newWordCounter = new WordCounter(newLongString);
            newWordCounter.StringSplitter();
            // Act
            bool testResult = newWordCounter.CheckWord(newWordCounter.GetArrayOfWords()[0]);
            // Assert
            Assert.Equal(false, testResult);
        }
    }
}
