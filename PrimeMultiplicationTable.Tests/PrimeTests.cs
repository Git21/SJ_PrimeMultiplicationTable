using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeMultiplicationTable.Tests
{
    public class PrimeTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void Given_ValidNumber_When_PassedPrimeNumber_Then_Return_True(int digit)
        {
            var output = Prime.IsPrimeNumber(digit);
            Assert.True(output);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        public void Given_ValidNumber_When_PassedNonPrimeNumber_Then_Return_False(int digit)
        {            
            var output = Prime.IsPrimeNumber(digit);
            Assert.False(output);
        }
        [Fact]
        public void Given_InvalidNumber_When_Passed_Then_Return_False()
        {
            var input = -1;
            var output = Prime.IsPrimeNumber(input);
            Assert.False(output);
        }

    }
}
