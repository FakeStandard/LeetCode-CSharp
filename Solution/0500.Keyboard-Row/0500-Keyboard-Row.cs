using System.Collections.Generic;

namespace Solution._0500.Keyboard_Row
{
    public class _0500_Keyboard_Row
    {
        public string[] FindWords(string[] words)
        {
            if (words == null || words.Length == 0) return new string[] { };

            List<string> res = new List<string>();

            HashSet<char> first = new HashSet<char>("qwertyuiop");
            HashSet<char> second = new HashSet<char>("asdfghjkl");
            HashSet<char> third = new HashSet<char>("zxcvbnm");

            foreach (string word in words)
            {
                if (word == "") continue;

                bool b = true;
                foreach (char letter in word)
                {
                    if (!first.Contains(letter))
                    {
                        b = false;
                        break;
                    }
                }

                if (b) res.Add(word);
            }

            return res.ToArray();
        }
    }
}
