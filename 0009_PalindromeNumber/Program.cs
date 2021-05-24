using System;

namespace _0009_PalindromeNumber
{
    /// <summary>
    /// Given an integer x, return true if x is palindrome integer.
    /// An integer is a palindrome when it reads the same backward as forward.For example, 121 is palindrome while 123 is not.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            // Ex1
            x = 121;
            bool r1 = IsPalindrome(x);
            Console.WriteLine(r1);

            // Ex2
            x = -121;
            bool r2 = IsPalindrome(x);
            Console.WriteLine(r2);

            // Ex3
            x = 10;
            bool r3 = IsPalindrome(x);
            Console.WriteLine(r3);

            // Ex4
            x = -101;
            bool r4 = IsPalindrome(x);
            Console.WriteLine(r4);

            Console.ReadLine();
        }

        /// <summary>
        /// 判斷數字是否回文
        /// </summary>
        /// <param name="x"></param>
        /// <returns>true or false</returns>
        public static bool IsPalindrome(int x)
        {
            // 0 算是回文, 自己也是自己本身
            if (x == 0)
                return true;

            // 回文不成立的狀況:
            // x 為負數
            // x 為 10 的倍數, 因為結尾 0 反轉後開頭無法為 0, 但回文開頭必須為 0 才能成立
            if (x < 0 || x % 10 == 0)
                return false;

            int reverseNum = 0;

            while (x > reverseNum)
            {
                reverseNum = reverseNum * 10 + x % 10;
                x /= 10;

                Console.WriteLine(reverseNum);
                Console.WriteLine(x);
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return x == reverseNum || x == reverseNum / 10;
        }
    }
}
