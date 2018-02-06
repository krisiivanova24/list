using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int newNum = int.Parse(Console.ReadLine());
            int position = nums.LastIndexOf(newNum);
            int result=nums.Take(position).Sum();
            Console.WriteLine(result);
            //result=nums.Sum()

            //for (int i = nums.Count - 1; i >= 0; i--)
            //{
            //    if (nums[i] == newNum)
            //    {
            //        position = i;
            //        break;
            //    }
            //}
            //if (position==0)
            //{
            //    Console.WriteLine("No occurrences were found!");
            //}
            //else
            //{
            //    for (int j = position - 1; j >= 0; j--)
            //    {
            //        result = result + nums[j];
            //    }
            //    Console.WriteLine(result);
            //}


        }
    }
}
