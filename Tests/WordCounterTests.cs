using Xunit;
using System;
using System.Collections.Generic;

namespace RepeatCounterApp.Objects
{
    public class RepeatCounterTest
    {
        [Fact]
        // test if the program can successfully grab the large string input from the user
        public void RepeatCounterConstructor_GetSetLongString_LongString()
        {
            // Arrange
            string newLongString = "This is a string";
            // Act
            RepeatCounter newRepeatCounter = new RepeatCounter(newLongString);
            // Assert
            Assert.Equal(newLongString, newRepeatCounter.GetLongString());
        }

        [Fact]
        // test to see if the program can grab the target word input from the user successfully
        public void RepeatCounterConstructor_GetSetTargetWord_TargetWord()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            RepeatCounter newRepeatCounter = new RepeatCounter(newLongString);
            // Act
            newRepeatCounter.SetTargetWord(newTargetWord);
            // Assert
            Assert.Equal(newTargetWord, newRepeatCounter.GetTargetWord());
        }

        [Fact]
        // test if the program can successfully break the large string into discreet segments
        public void StringSplitter_Split_ArrayofWords()
        {
            // Arrange
            string newLongString = "This is a string";
            RepeatCounter newRepeatCounter = new RepeatCounter(newLongString);
            string[] resultsList = new string[] {"This", "is", "a", "string"};
            // Act
            newRepeatCounter.StringSplitter();
            // Assert
            for (int i = 0; i < newRepeatCounter.GetArrayOfWords().Length; i++)
            {
                Assert.Equal(resultsList[i], newRepeatCounter.GetArrayOfWords()[i]);
            }
        }

        [Fact]
        // test if the program can check target word against others, for false result
        public void CheckWord_SingleCheck_False()
        {
            // Arrange
            string newLongString = "This is a string";
            string newTargetWord = "string";
            RepeatCounter newRepeatCounter = new RepeatCounter(newLongString);
            newRepeatCounter.SetTargetWord(newTargetWord);
            newRepeatCounter.StringSplitter();
            // Act
            bool testResult = newRepeatCounter.CheckWord(newRepeatCounter.GetArrayOfWords()[0]);
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
            RepeatCounter newRepeatCounter = new RepeatCounter(newLongString);
            newRepeatCounter.SetTargetWord(newTargetWord);
            newRepeatCounter.StringSplitter();
            // Act
            bool testResult = newRepeatCounter.CheckWord(newRepeatCounter.GetArrayOfWords()[3]);
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
            RepeatCounter newRepeatCounter = new RepeatCounter(newLongString);
            newRepeatCounter.SetTargetWord(newTargetWord);
            newRepeatCounter.StringSplitter();
            // Act
            bool testResult = newRepeatCounter.FindWord();
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
            RepeatCounter newRepeatCounter = new RepeatCounter(newLongString);
            newRepeatCounter.SetTargetWord(newTargetWord);
            newRepeatCounter.StringSplitter();
            // Act
            newRepeatCounter.FindWord();
            // Assert
            Assert.Equal(1, newRepeatCounter.GetWordCount());
        }
    }
}
