using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace technicalTask.Tests
{
    public class PositiveTestLastValueOfValueInWordsStat
    {
        [Fact]
        public void checkLastValueInWordsStat()
        {
            //Arrange
            FindTheWord findTheWord = new FindTheWord();
            string curFile = "D:\\CallController.log";
            string curWord = "StarWars";
            //Act
            string result = findTheWord.FindTheWordInTheText(curFile, curWord).Values.Last().ToString();
            //Assert
            Assert.Equal("2017-10-05 13:59:58.567 INFO  Start Channel on recorder - ID [1/3] for channel ID [3] - Mute [0]StarWars", result);
        }
    }
}
