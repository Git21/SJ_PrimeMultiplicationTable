using PrimeMultiplicationTable.Implemenation;
using PrimeMultiplicationTable.Interfaces;
using System;

namespace PrimeMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                Console.Write("Enter size of Prime Numbers Multiplication Table: ");
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= 1)
                        break;
                    else
                        InvalidNumberError();
                }
                else
                    InvalidNumberError();                    
            };
            IPrimeService myPrimeCalculator = new PrimeService();
            IPrint consoleDisplay = new ConsolePrint();
            var primeNumbers = myPrimeCalculator.GetPrimeNumbers(number).ToArray();
            var primeArray = myPrimeCalculator.GetPrimeMultiplcationTable(primeNumbers);
            consoleDisplay.Print(primeArray);
            Console.ReadKey();
        }

        private static void InvalidNumberError()
        {
            Console.WriteLine("Invalid Number. Try Again");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
