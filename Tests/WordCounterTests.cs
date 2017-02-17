using Xunit;
using System;
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
        public void StringSplitter_Split_ArrayofWords()
        {
            // Arrange
            string newLongString = "This is a string";
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
        // test if the program can check target word against others, for false result
        public void CheckWord_SingleCheck_False()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            WordCounter newWordCounter = new WordCounter(newLongString);
            newWordCounter.SetTargetWord(newTargetWord);
            newWordCounter.StringSplitter();
            // Act
            bool testResult = newWordCounter.CheckWord(newWordCounter.GetArrayOfWords()[0]);
            // Assert
            Assert.Equal(false, testResult);
        }

        [Fact]
        // test if the program can check target word against others, for true result
        public void CheckWord_SingleCheck_True()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            WordCounter newWordCounter = new WordCounter(newLongString);
            newWordCounter.SetTargetWord(newTargetWord);
            newWordCounter.StringSplitter();
            // Act
            bool testResult = newWordCounter.CheckWord(newWordCounter.GetArrayOfWords()[3]);
            // Assert
            Assert.Equal(true, testResult);
        }

        [Fact]
        // test if the program can find the target word in a large number of words
        public void FindWord_AllCheck_Bool()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            WordCounter newWordCounter = new WordCounter(newLongString);
            newWordCounter.SetTargetWord(newTargetWord);
            newWordCounter.StringSplitter();
            // Act
            bool testResult = newWordCounter.FindWord();
            // Assert
            Assert.Equal(true, testResult);
        }

        [Fact]
        // test if the program can return the number of times a word appears in a string
        public void FindWord_CountInstances_Count()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            WordCounter newWordCounter = new WordCounter(newLongString);
            newWordCounter.SetTargetWord(newTargetWord);
            newWordCounter.StringSplitter();
            // Act
            newWordCounter.FindWord();
            // Assert
            Assert.Equal(1, newWordCounter.GetWordCount());
        }
    }
}
