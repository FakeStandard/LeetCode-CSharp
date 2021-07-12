using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0917.Reverse_only_letters
{
    public class _0917_Reverse_only_letters
    {
        public string ReverseOnlyLetters(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char temp;
            var res = s.ToCharArray();

            while (left < right)
            {
                if (!Char.IsLetter(res[left]))
                    left++;
                else if (!Char.IsLetter(res[right]))
                    right--;
                else
                {
                    temp = res[left];
                    res[left] = res[right];
                    res[right] = temp;
                    left++;
                    right--;
                }
            }

            return new string(res);
        }
    }
}
