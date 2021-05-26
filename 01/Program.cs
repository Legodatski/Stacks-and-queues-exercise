using System;
using System.Linq;
using System.Collections.Generic;

namespace Softuni_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int[] command = ReadArray();
            int[] input = ReadArray();

            for (int i = 0; i < command[0]; i++)
                numbers.Push(input[i]);


            for (int i = 0; i < command[1]; i++)
                numbers.Pop();

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
