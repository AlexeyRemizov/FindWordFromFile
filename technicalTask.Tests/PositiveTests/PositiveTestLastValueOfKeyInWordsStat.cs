using System;
using technicalTask;
using Xunit;
using System.Linq;

namespace technicalTask.Tests
{
    
    public class PositiveTestLastValueOfKeyInWordsStat
    {
        [Fact]
        public void checkLastValueOfKeyInWordsStat()
        {
            //Arrange
            FindTheWord findTheWord = new FindTheWord();
            string curFile = "D:\\CallController.log";
            string curWord = "StarWars";
            //Act
            string result = findTheWord.FindTheWordInTheText(curFile, curWord).Keys.Last().ToString();
            //Assert
            Assert.Equal("5631170", result);
        }
    }
}
