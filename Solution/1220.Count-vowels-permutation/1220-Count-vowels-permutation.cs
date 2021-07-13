using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1220.Count_vowels_permutation
{
    public class _1220_Count_vowels_permutation
    {
        public int CountVowelPermutation(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 5;

            int[] curr = new int[5];
            int[] prev = new int[5], temp;

            int i;
            int MOD = 1000000007;

            for (i = 0; i < 5; i++)
                prev[i] = 1;

            for (i = 2; i <= n; i++)
            {
                // process a.
                curr[0] = (((prev[1] + prev[2]) % MOD) + prev[4]) % MOD;

                // process e.
                curr[1] = (prev[0] + prev[2]) % MOD;

                // process i.
                curr[2] = (prev[1] + prev[3]) % MOD;

                // process o.
                curr[3] = prev[2] % MOD;

                // process u.
                curr[4] = (prev[2] + prev[3]) % MOD;

                temp = prev;
                prev = curr;
                curr = temp;
            }

            int sum = 0;

            for (i = 0; i < prev.Length; i++)
                sum = (sum + prev[i]) % MOD;

            return sum;

            //if (n == 0) return 0;
            //if (n == 1) return 5;

            //int a = 1;
            //int e = 1;
            //int i = 1;
            //int o = 1;
            //int u = 1;

            //int a_new = 0;
            //int e_new = 0;
            //int i_new = 0;
            //int o_new = 0;
            //int u_new = 0;

            //// a->e
            //// e->a.i
            //// i->a.e.o.u
            //// o->i.u
            //// u->a

            //for (int k = 2; k <= n; k++)
            //{
            //    // process a.
            //    e_new = a;

            //    // process e.
            //    a_new = e;
            //    i_new = e;

            //    // process i.
            //    a_new += i;
            //    e_new += i;
            //    o_new += i;
            //    u_new += i;

            //    // process o.
            //    i_new += o;
            //    u_new += o;

            //    // process u.
            //    a_new += u;

            //    a = a_new;
            //    e = e_new;
            //    i = i_new;
            //    o = o_new;
            //    u = u_new;

            //    a_new = 0;
            //    e_new = 0;
            //    i_new = 0;
            //    o_new = 0;
            //    u_new = 0;
            //}

            //return a + e + i + o + u;
        }
    }
}
