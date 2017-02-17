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
    }
}
