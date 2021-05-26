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

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = ReadArray();

                switch (input[0])
                {
                    case 1:
                        numbers.Push(input[1]);
                        break;
                    case 2:
                        numbers.Pop();
                        break;
                    case 3:
                        if (numbers.Count != 0)
                            Console.WriteLine(numbers.Max());
                        break;
                    case 4:
                        if (numbers.Count != 0)
                            Console.WriteLine(numbers.Min());
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }

        private static int[] ReadArray()
        {

            return Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
