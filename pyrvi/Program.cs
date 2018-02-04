using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commands
{
    class Program
    {
        static void PrintArray (string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    Console.Write($"{array[i]}, ");
                }
                
            }
        }
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            byte number = byte.Parse(Console.ReadLine());
            string command = null;
            for (byte i = 1; i <= number; i++)
            {
                command = Console.ReadLine();
                if (command == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (command == "Distinct")
                {
                    for (int k = 0; k < array.Length-1; k++)
                    {
                        for (int j = k+1; j < array.Length ; j++)
                        {
                            if (array[k] == array[j])
                            {
                                array[j] = null;
                            }
                        }
                    }
                    //string[] arr1=array.Distinct().ToArray();
                }
                else
                {
                    string[] comParam = command.Split(' ').ToArray();
                    int index = int.Parse(comParam[1]);
                    string word = comParam[2];
                    array[index] = word;
                }               

            }
            //Console.WriteLine(string.Join(", ", array));
            PrintArray(array);
        }
    }
}

