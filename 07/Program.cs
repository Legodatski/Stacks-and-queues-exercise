using System;
using System.Linq;
using System.Collections.Generic;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                pumps.Enqueue(input);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (int[] pump in pumps)
                {
                    int fuel = pump[0];
                    int destination = pump[1];

                    totalFuel += fuel - destination;

                    if (totalFuel < 0)
                    {
                        index++;
                        pumps.Enqueue(pumps.Dequeue());
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);

        }
    }
}
