using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0717._1_bit_and_2_bit_characters
{
    public class _0717_1_bit_and_2_bit_characters
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            bool res = false;

            for (int i = 0; i < bits.Length;)
            {
                if (bits[i] == 0)
                {
                    i++;
                    res = true;

                }
                else if (bits[i] == 1)
                {
                    i += 2;
                    res = false;
                }
            }

            return res;
        }
    }
}
