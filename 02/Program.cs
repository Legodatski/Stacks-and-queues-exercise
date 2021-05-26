using System;
using System.Linq;
using System.Collections.Generic;

namespace Softuni_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            int[] command = ReadArray();
            int[] input = ReadArray();

            for (int i = 0; i < command[0]; i++)
                numbers.Enqueue(input[i]);


            for (int i = 0; i < command[1]; i++)
                numbers.Dequeue();

            if (numbers.Contains(command[2]))
                Console.WriteLine("true");
            else if (numbers.Count == 0)
                Console.WriteLine("0");
            else
                Console.WriteLine(numbers.Min());

        }

        private static int[] ReadArray()
        {

            return Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
