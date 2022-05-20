using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0202.Happy_number
{
    public class _0202_Happy_numbercs
    {
        public bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();
            int sum = 0, digit = 0;

            while (true)
            {
                sum = 0;

                while (n > 0)
                {
                    digit = n % 10;
                    sum += digit * digit;
                    n /= 10;
                }

                n = sum;

                if (!set.Add(n)) return false;
                if (n == 1) return true;
            }
        }
    }
}
