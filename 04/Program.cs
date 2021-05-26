using System;
using System.Linq;
using System.Collections.Generic;

namespace Softuni_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = ReadArray();
            Queue<int> numbers = new Queue<int>(input);

            Console.WriteLine(numbers.Max());

            while (numbers.Count > 0 && n - numbers.Peek() >= 0)
            {
                n -= numbers.Dequeue();
            }

            if (numbers.Count == 0)
                Console.WriteLine("Orders complete");
            else
            {
                Console.Write("Orders left: ");

                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
            }

        }

        private static int[] ReadArray()
        {
            return Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
