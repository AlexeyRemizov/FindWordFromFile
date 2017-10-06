using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace technicalTask.Tests
{
    class PositiveTestCompareFirstWithLastValuesOfKeys
    {
        [Fact]
        public void CheckLastValueOfKeyInWordsStat()
        {
            //Arrange
            FindTheWord findTheWord = new FindTheWord();
            string curFile = "D:\\CallController.log";
            string curWord = "StarWars";
            //Act
            string resultLast = findTheWord.FindTheWordInTheText(curFile, curWord).Keys.Last().ToString();
            string resultFirst = findTheWord.FindTheWordInTheText(curFile, curWord).Keys.First().ToString();
            //Assert
            Assert.Equal(resultLast, resultFirst);
        }
    }
}
