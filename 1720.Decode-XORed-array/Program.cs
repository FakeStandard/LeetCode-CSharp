using System;

namespace _1720.Decode_XORed_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 0 2 1
            Console.WriteLine(1 ^ 0);
            Console.WriteLine(0 ^ 2);
            Console.WriteLine(2 ^ 1);

            // 1 2 3
            Console.WriteLine(1 ^ 1);
            Console.WriteLine((1 ^ 1) ^ 2);
            Console.WriteLine(((1 ^ 1) ^ 2) ^ 3);

            Console.ReadLine();
        }
    }

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
