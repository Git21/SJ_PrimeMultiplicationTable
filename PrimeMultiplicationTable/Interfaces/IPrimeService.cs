using System.Collections.Generic;

namespace PrimeMultiplicationTable.Interfaces
{
    public interface IPrimeService
    {
        List<int> GetPrimeNumbers(int number);
        int[,] GetPrimeMultiplcationTable(int[] primesArray);
    }
}
