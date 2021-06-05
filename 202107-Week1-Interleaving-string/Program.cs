using System;

namespace _202107_Week1_Interleaving_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string s1;
            string s2;
            string s3;

            // ex1
            s1 = "aabcc";
            s2 = "dbbca";
            s3 = "aadbbcbcac";
            // Output: true
            Console.WriteLine(s.IsInterleave(s1, s2, s3));

            // ex2
            s1 = "aabcc";
            s2 = "dbbca";
            s3 = "aadbbbaccc";
            // Output: false
            Console.WriteLine(s.IsInterleave(s1, s2, s3));

            // ex3
            s1 = "";
            s2 = "";
            s3 = "";
            // Output: true
            Console.WriteLine(s.IsInterleave(s1, s2, s3));

            // test
            s1 = "";
            s2 = "";
            s3 = "a";
            // Output: false
            Console.WriteLine(s.IsInterleave(s1, s2, s3));

            // test
            s1 = "a";
            s2 = "";
            s3 = "c";
            // Output: false
            Console.WriteLine(s.IsInterleave(s1, s2, s3));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            // SOME ERROR...

            if (s1.Length == 0 && s2.Length == 0 && s3.Length > 0) return false;

            int index1 = 0;
            int index2 = 0;
            int index3 = 0;

            while (true)
            {
                if (index1 == s1.Length && index2 == s2.Length)
                    return true;
                else if (index1 < s1.Length && s3[index3] == s1[index1])
                {
                    index3++;
                    index1++;
                    continue;
                }
                else if (index2 < s2.Length && s3[index3] == s2[index2])
                {
                    index3++;
                    index2++;
                    continue;
                }
                else
                    return false;
            }
        }
    }
}
