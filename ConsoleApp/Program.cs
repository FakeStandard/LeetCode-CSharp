using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string a = "first";
                Console.WriteLine(a);
            }
            

            {
                string a = "scope";
                Console.WriteLine(a);
            }

            Console.WriteLine("=====");

            Console.WriteLine("=====");
            Console.WriteLine(2 ^ 3);
            Console.WriteLine(4 ^ 1);
            Console.WriteLine((4 ^ 1) ^ 2);
            Console.WriteLine(((4 ^ 1) ^ 2) ^ 1);
            Console.WriteLine((((4 ^ 1) ^ 2) ^ 1) ^ 2);
            Console.WriteLine("=====");
            Console.WriteLine("=====");
            Console.WriteLine(16 & 15);
            Console.WriteLine(15 & 14);
            Console.WriteLine(14 & 13);
            Console.WriteLine(1 & 0);
            Console.WriteLine("=====");

            HashSet<string> set = new HashSet<string>();

            set.Add("1");
            set.Add("2");
            set.Add("3");
            set.Add("1");
            set.Add("1");
            set.Add("1");


            // 0000 >> 0001
            Console.WriteLine(0 >> 1); //0

            // 0001 >> 0001
            Console.WriteLine(1 >> 1); //0

            // 0010 >> 0001
            Console.WriteLine(2 >> 1); //1

            // 0011 >> 0001
            Console.WriteLine(3 >> 1); //1

            // 0100 >> 0001
            Console.WriteLine(4 >> 1); //2

            Console.WriteLine("==========");

            // 0000 << 0001
            Console.WriteLine(0 << 1); //0

            // 0001 << 0001
            Console.WriteLine(1 << 1); //2

            // 0010 << 0001
            Console.WriteLine(2 << 1); //4

            // 0011 << 0001
            Console.WriteLine(3 << 1); //6

            // 0100 << 0001
            Console.WriteLine(4 << 1); //8

            Console.WriteLine(Convert.ToInt32("11100", 2));

            // 60
            Console.WriteLine(60 >> 1);
            Console.WriteLine(14 << 1);

            int num = 20;

            // 80
            Console.WriteLine(num << 2);

            // 5
            Console.WriteLine(num >> 2);

            Console.ReadLine();
        }
    }
}
