using PrimeMultiplicationTable.Interfaces;
using System;

namespace PrimeMultiplicationTable.Implemenation
{
    public class ConsolePrint : IPrint
    {
        public void Print(int[,] array)
        {
            if (array == null)
            {
                Console.WriteLine("Input Array is empty.");
                return;
            }
            var hLen = array.GetLength(0);
            var vLen = array.GetLength(1);
            Console.WriteLine("Result");
            Console.WriteLine("");
            for (int i = 0; i < hLen; i++)
            {
                for (int j = 0; j < vLen; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write(string.Format("{0,5} ", " "));
                        continue;
                    }
                    Console.Write(string.Format("{0,5} ", array[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
