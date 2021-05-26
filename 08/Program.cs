using System;
using System.Collections.Generic;
using System.Linq;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<int> firstHalf = new Queue<int>();
            Stack<int> secondHalf = new Stack<int>();

            foreach (var item in input)
            {
                firstHalf.Enqueue(item);
                secondHalf.Push(item);
            }

            int index = 2;
            string output = "";

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (firstHalf.Peek() == 40)
                {
                    index = 1;
                }
                else
                {
                    index = 2;
                }

                if (firstHalf.Peek() + index == secondHalf.Peek())
                {
                    output = "YES";
                    firstHalf.Dequeue();
                    secondHalf.Pop();
                }
                else
                {
                    output = "NO";
                    return;
                }
            }

            Console.WriteLine(output);
        }
    }
}
