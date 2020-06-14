using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeMultiplicationTable
{
    public static class Prime
    {
        public static bool IsPrimeNumber(int digit)
        {
            if (digit <= 1) return false;

            if((digit & 1) == 0)
                return (digit == 2);
            
            var limit = (int)Math.Floor(Math.Sqrt(digit));
            for (int i = 3; i <= limit; i += 2)
                // divide by any other number other than 1 and itself is not a prime number
                if (digit % i == 0) 
                    return false;

            return true;
        }
    }
}
