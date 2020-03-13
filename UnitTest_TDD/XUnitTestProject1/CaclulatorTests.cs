using Calc;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class CaclulatorTests
    {
        [Fact]
        public void CalculatorShouldReturnZero()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Add(0, 0);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculatorShouldReturnTwo()
        {
            //Arrange
            var sut = new Calculator();

            // Act
            var result = sut.Add(1, 1);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void CalculatorShouldReturnThree()
        {
            //Arrange  - setup your variables, or your raw data that you need
            // to test your code
            var sut = new Calculator();
            int testOne = 5;
            int testTwo = 2;

            //Act -  call the method that you actually WANT to test
            var result = sut.Subtract(testOne, testTwo);

            //Assert - make an ASSERTION, you want to say "Hey, this method is
            // going to EQUAL this result!
            Assert.Equal(3, result);
            
        }

        [Fact]
        public void CalculatorShouldReturnEight()
        {
            //Arrange  - setup your variables, or your raw data that you need
            // to test your code
            var sut = new Calculator();
            int testOne = 10;
            int testTwo = 2;

            //Act -  call the method that you actually WANT to test
            var result = sut.Subtract(testOne, testTwo);

            //Assert - make an ASSERTION, you want to say "Hey, this method is
            // going to EQUAL this result!
            Assert.Equal(8, result);
        }

        [Fact]
        public void WillSortAscending() 
        {
            // arrange
            var sut = new Calculator();
            var input = new int[] {5, 4, 3, 2, 1};
            var expectedArray = new int[] { 1, 2, 3, 4, 5 };
            // act
            var result = sut.BubbleSort(input);


            // assert

            Assert.Equal(expectedArray, result);
        }

        [Fact]
        public void WillSortAscendingWithSix() 
        {
            // arrange
            var sut = new Calculator();
            var input = new int[] {6, 4, 3, 2, 1};
            var expectedArray = new int[] { 1, 2, 3, 4, 6 };
            // act
            var result = sut.BubbleSort(input);


            // assert

            Assert.Equal(expectedArray, result);
        }




    }
}
