using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1299.Replace_elements_with_greatest_element_on_right_side
{
    public class _1299_Replace_elements_with_greatest_element_on_right_side
    {
        public int[] ReplaceElements(int[] arr)
        {
            int[] res = new int[arr.Length];
            int max = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                max = 0;

                // search max on right side
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > max)
                        max = arr[j];
                }

                res[i] = max;
            }

            res[res.Length - 1] = -1;

            return res;
        }
    }
}
