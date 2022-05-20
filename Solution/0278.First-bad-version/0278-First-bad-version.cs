using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0278.First_bad_version
{
    public class _0278_First_bad_version
    {
        /* The isBadVersion API is defined in the parent class VersionControl.
            bool IsBadVersion(int version); */

        public int FirstBadVersion(int n)
        {
            // binary search
            int left = 1, right = n, mid = 0;

            while (left < right)
            {
                mid = left + (right - left) / 2;

                if (IsBadVersion(mid)) right = mid;
                else left = mid + 1;
            }

            return left;
        }

        private bool IsBadVersion(int version) { return true; }
    }
}
