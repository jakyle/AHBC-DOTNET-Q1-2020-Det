using System;
using Unit_test;
using Xunit;

namespace Unit_test_test
{
    public class TempConverterTest
    {
        [Fact]
        public void TempConverterWillReturnZero()
        {
            // Arrange
            var sut = new TempConverter();
            var expected = "0(C)";

            // Act
            var result = sut.ConvertTo("C", 2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TempConverterWillReturn20()
        {
            //Arrange
            var sut = new TempConverter();
            var expected = "20(C)";

            // Act
            var result = sut.ConvertTo("C", 68);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
