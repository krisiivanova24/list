using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            foreach (var item in numbers)
            {
                if (item == numbers.Min() || item == numbers.Max())
                {
                    newList.Add(item);
                }
            }
            newList.Sort();
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
