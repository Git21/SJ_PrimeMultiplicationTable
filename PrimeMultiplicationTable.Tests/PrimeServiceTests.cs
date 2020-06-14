using PrimeMultiplicationTable.Implemenation;
using PrimeMultiplicationTable.Interfaces;
using System;
using Xunit;

namespace PrimeMultiplicationTable.Tests
{
    public class PrimeServiceTests
    {
        #region GetPrimeNumbers Tests
        [Fact]
        public void Given_GreaterThanOneInput_Then_Return_CorrectArrayCount()
        {
            var arraySize = 5;

            IPrimeService primeNumbers = new PrimeService();
            var primeArray = primeNumbers.GetPrimeNumbers(arraySize);
            Assert.Equal(arraySize, primeArray.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Given_ValidArraySize_Then_Return_PrimeNumbers(int arraySize)
        {
            IPrimeService primeNumbers = new PrimeService();
            var primeArray = primeNumbers.GetPrimeNumbers(arraySize);
            Assert.Equal(arraySize, primeArray.Count);
            Assert.Contains(2, primeArray);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        public void Given_ValidArraySize_Then_DoNotReturn_CompositeNumbers(int arraySize)
        {
            IPrimeService primeNumbers = new PrimeService();
            var primeArray = primeNumbers.GetPrimeNumbers(arraySize);
            Assert.Equal(arraySize, primeArray.Count);
            Assert.DoesNotContain(4, primeArray);
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Given_LessThanOneArraySize_Then_Return_EmptyArray(int arraySize)
        {
            IPrimeService primeNumbers = new PrimeService();
            var primeArray = primeNumbers.GetPrimeNumbers(arraySize);
            Assert.Empty(primeArray);
        }
        #endregion

        #region Get Prime Multiplcation Table Tests
        [Fact]
        public void Given_ValidInputArray_Then_Return_CorrectTableMatrixCount()
        {
            int[] array = { 2, 3, 5, 7 };

            IPrimeService primeNumbers = new PrimeService();
            var primeArray = primeNumbers.GetPrimeMultiplcationTable(array);
            Assert.Equal(array.Length + 1, primeArray.GetLength(0));
            Assert.Equal(array.Length + 1, primeArray.GetLength(1));
        }
        [Fact]
        public void Given_ValidInputArray_Then_Return_PrimeNumbersMultiplicationTable()
        {
            int[] array = { 2, 3, 5, 7 };

            IPrimeService primeNumbers = new PrimeService();
            var primeArray = primeNumbers.GetPrimeMultiplcationTable(array);
            Assert.Equal(array.Length + 1, primeArray.GetLength(0));
            Assert.Equal(array.Length + 1, primeArray.GetLength(1));
            Assert.Equal(4, primeArray[1,1]);
        }

        [Fact]
        public void Given_EmptyInputArray_Then_Return_Null()
        {
            int[] array = { };

            IPrimeService primeNumbers = new PrimeService();
            var primeArray = primeNumbers.GetPrimeMultiplcationTable(array);
            Assert.Null(primeArray);
        }
        #endregion
    }
}
