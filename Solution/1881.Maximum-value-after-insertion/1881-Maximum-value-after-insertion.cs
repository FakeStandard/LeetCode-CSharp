using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1881.Maximum_value_after_insertion
{
    public class _1881_Maximum_value_after_insertion
    {
        public string MaxValue(string n, int x)
        {
            int i = 0;

            if (n[0] == '-')
            {
                for (i = 1; i < n.Length; i++)
                {
                    if (int.Parse(n[i].ToString()) > x)
                        return n.Substring(0, i) + x + n.Substring(i);
                }
            }
            else
            {
                for (i = 0; i < n.Length; i++)
                {
                    if (int.Parse(n[i].ToString()) < x)
                        return n.Substring(0, i) + x + n.Substring(i);
                }
            }

            return n.Insert(i, x.ToString());
        }
    }
}
