using System;

namespace _1491.Average_salary_excluding_the_minimum_and_maximum_salary
{
    public class Solution
    {
        public double Average(int[] salary)
        {
            if (salary.Length == 0) return 0;

            int min = salary[0];
            int max = salary[0];
            double sum = 0;
            int i = 0;
            double res = 0.00;

            for (i = 0; i < salary.Length; i++)
            {
                if (salary[i] < min)
                    min = salary[i];
                else if (salary[i] > max)
                    max = salary[i];
                sum += salary[i];
            }

            return (sum - min - max) / (salary.Length - 2);

            //if (salary.Length == 0) return 0;

            //int min = salary[0];
            //int max = 0;
            //int i = 0;
            //double res = 0.00;

            //for (i = 0; i < salary.Length; i++)
            //{
            //    if (salary[i] < min)
            //        min = salary[i];
            //    else if (salary[i] > max)
            //        max = salary[i];
            //}

            //for (i = 0; i < salary.Length; i++)
            //{
            //    if (salary[i] != min && salary[i] != max)
            //        res += salary[i];
            //}

            //return res / (salary.Length - 2);
        }
    }
}
