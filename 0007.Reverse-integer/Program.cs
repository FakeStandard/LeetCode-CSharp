using System;

namespace _0007.Reverse_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            // Ex1
            x = 123;
            int r1 = Reverse(x);
            Console.WriteLine(r1);

            // EX2
            x = -123;
            int r2 = Reverse(x);
            Console.WriteLine(r2);

            // Ex3
            x = 120;
            int r3 = Reverse(x);
            Console.WriteLine(r3);

            // Ex4
            x = 0;
            int r4 = Reverse(x);
            Console.WriteLine(r4);

            // Ex5
            x = -2147483648;
            int r5 = Reverse(x);
            Console.WriteLine(r5);

            Console.ReadLine();
        }

        /// <summary>
        /// 反轉數字, 若有符號(負數)反轉後依然是負數
        /// </summary>
        /// <param name="x"></param>
        /// <returns>返回反轉結果</returns>
        public static int Reverse(int x)
        {
            try
            {
                // 拆解成字元
                char[] ch = x.ToString().ToCharArray();

                // 反轉陣列
                Array.Reverse(ch);

                string result = new string(ch);

                if (result.Contains("-"))
                    result = "-" + (result.Replace("-", ""));

                return int.Parse(result);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
