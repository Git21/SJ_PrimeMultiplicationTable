using PrimeMultiplicationTable.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PrimeMultiplicationTable.Implemenation
{
    public class PrimeService : IPrimeService
    {
        public List<int> GetPrimeNumbers(int arraySize)
        {
            var primeNumbers = new List<int>();
            int i = 0;

            while (primeNumbers.Count < arraySize)
            {
                if (Prime.IsPrimeNumber(i))
                    primeNumbers.Add(i);
                i++;
            }
            return primeNumbers;
        }
        public int[,] GetPrimeMultiplcationTable(int[] primesArray)
        {
            if (primesArray.Length == 0) return null;
            var arrayLength = primesArray.Length;

            int[,] multiplicationTable = new int[arrayLength + 1, arrayLength + 1];
            CopyFirstRowAndColumn(primesArray, multiplicationTable);
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    multiplicationTable[i + 1, j + 1]
                        = primesArray[i] * primesArray[j];
                }
            }
            return multiplicationTable;
        }
        private static void CopyFirstRowAndColumn(int[] primesArray, int[,] mulitpliedPrimes)
        {
            int i = 1;
            primesArray.ToList().ForEach(p =>
            {
                mulitpliedPrimes[0, i] = p;
                mulitpliedPrimes[i, 0] = p;
                i++;
            });
        }
    }
}