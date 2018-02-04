using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace povtarqshti
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int times = 1;
            int maxTimes = 0;
            int maxElement = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        times++;
                    }
                }
                if (times > maxTimes)
                {
                    maxTimes = times;
                    maxElement = numbers[i];
                    //Console.WriteLine(maxElement+ " "+ maxTimes );
                }
                times = 1;
            }
           // Console.WriteLine(new string(maxElement.ToString()[0], maxTimes));
            List<int> newList = new List<int>();

            for (int i = 0; i < maxTimes; i++)
            {
                newList.Add(maxElement);
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
