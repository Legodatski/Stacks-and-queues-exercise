using System;
using System.Collections.Generic;
using System.Linq;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();
            string[] last = null;
            string lastDeleted = null;

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "1":
                        text.Push(command[1]);
                        break;
                    case "2":

                        for (int j = 0; j < int.Parse(command[1]); j++)
                        {
                            lastDeleted += text.TryPop();
                        }

                        break;
                    case "3":
                        for (int j = 0; i < text.Count; i++)
                        {
                            if (j == int.Parse(command[1]))
                            {
                                Console.WriteLine(command[j]);
                                break;
                            }
                        }
                        break;
                    case "4":

                        if (last[0] == "1")
                        {
                            for (int j = 0; j < last[1].Length; j++)
                            {
                                text.Pop();
                            }
                        }
                        else
                        {
                            text.Push(lastDeleted);
                        }

                        break;
                }

                if (command[0] != "3" || command[0] != "4")
                    last = command;
            }
        }
    }
}
