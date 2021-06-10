using System;
using System.Collections.Generic;

namespace _1436.Destination_city
{
    public class Solution
    {
        public string DestCity(IList<IList<string>> paths)
        {
            string end = paths[0][1];
            bool flag = true;

            while (flag)
            {
                flag = false;

                for (int i = 0; i < paths.Count; i++)
                {
                    if (end == paths[i][0])
                    {
                        end = paths[i][1];
                        flag = true;
                    }
                }
            }

            return end;
        }
    }
}
