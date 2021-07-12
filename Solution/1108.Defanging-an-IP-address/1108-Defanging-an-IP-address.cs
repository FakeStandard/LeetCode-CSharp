using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1108.Defanging_an_IP_address
{
    public class _1108_Defanging_an_IP_address
    {
        public string DefangIPaddr(string address)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var s in address)
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
