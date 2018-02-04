using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spisyk
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        newList.Add(numbers[i]);
            //    }
            //}
            foreach (var item in numbers)
            {
                if (item %2==0)
                {
                    newList.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
