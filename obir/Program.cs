using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            int num = int.Parse(Console.ReadLine());
            List<string> systavki = new List<string>();
            int broiSystavki = 0;
            
            for (int i = 0; i < products.Length; i++)
            {

                if (products[i].Length == num)
                {
                    broiSystavki++;
                    systavki.Add(products[i]);
                    Console.WriteLine($"Adding {products[i]}.");
                }
            }
            Console.WriteLine($"Made pizza with total of {broiSystavki} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", systavki)}.");
        }
    }
}
