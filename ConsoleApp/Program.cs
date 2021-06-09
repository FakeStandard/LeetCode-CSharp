using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] salary = { 4000, 3000, 1000, 2000 };
            Console.WriteLine(Average(salary));

            Console.ReadLine();
        }

        public static double Average(int[] salary)
        {
            if (salary.Length == 0) return 0;

            int min = salary[0];
            int max = 0;
            int i = 0;
            double res = 0.00;

            for ( i = 0; i < salary.Length; i++)
            {
                if (salary[i] < min)
                    min = salary[i];
                else if (salary[i] > max)
                    max = salary[i];
            }

            for (i = 0; i < salary.Length; i++)
            {
                if (salary[i] != min && salary[i] != max)
                    res += salary[i];
            }

            return res / (salary.Length - 2);
        }
    }
}
