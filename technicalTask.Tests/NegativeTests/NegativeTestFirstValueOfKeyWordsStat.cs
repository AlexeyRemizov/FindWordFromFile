using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace technicalTask.Tests
{
    class NegativeTestFirstValueOfKeyWordsStat
    {
        [Fact]
        public void CheckLastValueOfKeyInWordsStat()
        {
            //Arrange
            FindTheWord findTheWord = new FindTheWord();
            string curFile = "D:\\CallController.log";
            string curWord = "StarWars";
            //Act
            string result = findTheWord.FindTheWordInTheText(curFile, curWord).Keys.Last().ToString();
            //Assert
            Assert.Equal(null, result);
        }
    }
}
