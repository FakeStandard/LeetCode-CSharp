using System;

namespace _1342.Number_of_steps_to_reduce_a_number_to_zero
{
    public class Solution
    {
        public int NumberOfSteps(int num)
        {
            int count = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num--;

                count++;
            }

            return count;
        }
    }
}
