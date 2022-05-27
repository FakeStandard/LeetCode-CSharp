using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0077.Combinations
{
    public class _0077_Combinations
    {
        private IList<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> Combine(int n, int k)
        {
            var temp = new List<int>();

            recursive(n, k, temp, 1);

            return res;
        }

        private void recursive(int n, int k, IList<int> temp, int level)
        {
            if (temp.Count == k)
                res.Add(new List<int>(temp));
            else
            {
                for (int i = level; i <= n; i++)
                {
                    temp.Add(i);

                    recursive(n, k, temp, i + 1);

                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
    }
}
