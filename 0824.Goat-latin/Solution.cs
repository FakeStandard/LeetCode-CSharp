using System;
using System.Text;

namespace _0824.Goat_latin
{
    public class Solution
    {
        public string ToGoatLatin(string sentence)
        {
            StringBuilder sb = new StringBuilder();

            string[] s = sentence.Split(" ");

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToLower().StartsWith("a") || s[i].ToLower().StartsWith("e") || s[i].ToLower().StartsWith("i") || s[i].ToLower().StartsWith("o") || s[i].ToLower().StartsWith("u"))
                {
                    sb.Append(s[i]);
                    sb.Append("ma");
                }
                else
                {
                    sb.Append(s[i].Substring(1));
                    sb.Append(s[i][0]);
                    sb.Append("ma");
                }

                for (int j = 0; j < i + 1; j++)
                    sb.Append("a");

                sb.Append(" ");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
