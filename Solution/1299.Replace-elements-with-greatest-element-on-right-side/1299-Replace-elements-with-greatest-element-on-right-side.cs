using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1299.Replace_elements_with_greatest_element_on_right_side
{
    public class _1299_Replace_elements_with_greatest_element_on_right_side
    {
        public int[] ReplaceElements(int[] arr)
        {
            int max = -1;
            int temp = -1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                temp = arr[i];
                arr[i] = max;
                max = temp > max ? temp : max;
            }

            return arr;
        }
    }
}
