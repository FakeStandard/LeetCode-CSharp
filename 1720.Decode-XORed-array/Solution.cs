using System;

namespace _1720.Decode_XORed_array
{
    public class Solution
    {
        public int[] Decode(int[] encoded, int first)
        {
            int[] res = new int[encoded.Length + 1];

            res[0] = first;

            for (int i = 0; i < encoded.Length; i++)
            {
                first = first ^ encoded[i];
                res[i + 1] = first;
            }

            return res;
        }
    }
}
