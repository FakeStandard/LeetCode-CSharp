using System;

namespace _0001.Two_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            int target;

            // Ex1
            nums = new int[] { 2, 7, 11, 15 };
            target = 9;
            int[] r1 = TwoSum(nums, target);
            Console.WriteLine($"[{r1[0]}, {r1[1]}]");

            // Ex2
            nums = new int[] { 3, 2, 4 };
            target = 6;
            int[] r2 = TwoSum(nums, target);
            Console.WriteLine($"[{r2[0]}, {r2[1]}]");

            // Ex3
            nums = new int[] { 3, 3 };
            target = 6;
            int[] r3 = TwoSum(nums, target);
            Console.WriteLine($"[{r3[0]}, {r3[1]}]");

            Console.ReadLine();
        }

        /// <summary>
        /// 計算陣列中任一兩個值是否等於 target
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>回傳兩值的陣列索引</returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int i, j;

            // 透過雙迴圈逐一走訪
            for (i = 0; i < nums.Length; i++)
            {
                // 因不可與本身計算, 故取 i+1 略過本身, 以及計算過的值
                for (j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }

            throw new Exception("No solution.");
        }
    }
}
