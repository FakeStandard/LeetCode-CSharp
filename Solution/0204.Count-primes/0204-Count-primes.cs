using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0204.Count_primes
{
    public class _0204_Count_primes
    {
        public int CountPrimes(int n)
        {
            if (n < 2)
                return 0;

            bool[] primes = new bool[n];
            primes[0] = false;
            primes[1] = false;

            int i = 0;

            for (i = 2; i < n; i++)
                primes[i] = true;

            i = 2;
            while (i < n)
            {
                if (primes[i])
                    for (int j = 2; i * j < n; j++)
                        primes[i * j] = false;
                i++;
            }

            int count = 0;
            i = 2;

            while (i < n)
            {
                if (primes[i])
                    count++;
                i++;
            }

            return count;
        }
    }
}
