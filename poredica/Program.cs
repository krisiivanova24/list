using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poredica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int times = 1;
            int bestStart = 0;
            int bestLen = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                for (int y = i+1; y < arr.Length; y++)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        times++;
                        if (times > bestLen)
                        {
                            bestLen = times;
                        }
                        bestStart = arr[i];

                    }
                    else
                    {
                        for (int j = i; j < arr.Length - 1; j++)
                        {
                            times = 1;
                            if (arr[i] == arr[i + 1])
                            {
                                times++;
                                if (times > bestLen)
                                {
                                    bestLen = times;
                                }
                                bestStart = arr[i];

                            }
                        }
                        times = 0;
                    }
                }
                
                
            }

            List<int> num = new List<int>();
            for (int i = 0; i < bestLen; i++)
            {
                num.Insert(i, bestStart);
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
