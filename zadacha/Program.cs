using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            byte count = 1;
            num1.Sort();

            //for (int i = 0; i < num1.Count; i++)
            //{
            //    for (int j = 0; j < num1.Count - 1; j++)
            //    {
            //        if (num1[j] > num1[j + 1])
            //        {
            //            int x = num1[j];
            //            num1[j] = num1[j + 1];
            //            num1[j + 1] = x;
            //        }
            //    }
            //}
            Console.WriteLine(string.Join(" <= ", num1));
            int n = num1[0];
            for (int i = 1; i < num1.Count; i++)
            {
                if (n != num1[i] )
                {
                    Console.WriteLine($"{n} -> {count}");
                    count = 1;
                    n = num1[i];
                }
                else
                {
                    count++;
                }                
            }
            Console.WriteLine($"{n} -> {count}");

        }
    }
}
