using System;

namespace _0231.Power_of_two
{
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            // Shift operators
            return (n > 0) && (n & (n - 1)) == 0;
        }
    }
}
