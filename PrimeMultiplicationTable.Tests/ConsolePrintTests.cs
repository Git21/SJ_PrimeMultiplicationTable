using PrimeMultiplicationTable.Implemenation;
using PrimeMultiplicationTable.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace PrimeMultiplicationTable.Tests
{
    public class ConsolePrintTests
    {
        [Fact]
        public void Given_ValidInputArray_Then_PrintArray()
        {
            int[,] input = new int[,] { { 0, 2 }, { 2, 4 } };
            var output = new StringWriter();
            Console.SetOut(output);
            IPrint printConsole = new ConsolePrint();
            printConsole.Print(input);
            var actualOutput = output.ToString();
            Assert.Contains("4", actualOutput);
        }

        [Fact]
        public void Given_InputArray_Null_Then_PrintArray()
        {
            int[,] input = null;
            var output = new StringWriter();
            Console.SetOut(output);

            IPrint printConsole = new ConsolePrint();
            printConsole.Print(input);
            var actualOutput = output.ToString();
            Assert.Equal("Input Array is empty.\r\n", actualOutput);
        }
    }
}
