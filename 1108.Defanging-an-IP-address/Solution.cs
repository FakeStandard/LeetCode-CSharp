using System;
using System.Text;

namespace _1108.Defanging_an_IP_address
{
    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var s in address)
            {
                if (s == '.')
                    sb.Append("[.]");
                else
                    sb.Append(s);
            }

            return sb.ToString();

            #region Eazy Solution
            //return address.Replace(".", "[.]");
            #endregion
        }
    }
}
