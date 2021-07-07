using System;
using System.Collections.Generic;
using System.Linq;

namespace Cheque.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            int[] input = new int[4];
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Enter amount #{i + 1}");
                input[i] = int.Parse(Console.ReadLine());
            }

            int[] cheque = new int[3];
            bool isStop = false;

            for (int i = 0; i < input.Max() + 1; i++)
            {
                if (isStop) break;
                for (int j = i; j < input.Max() + 1; j++)
                {
                    if (isStop) break;
                    for (int k = i; k < input.Max() + 1; k++)
                    {
                        if (IsCheck(input[0], i, j, k) && IsCheck(input[1], i, j, k) && IsCheck(input[2], i, j, k) && IsCheck(input[3], i, j, k))
                        {
                            cheque[0] = i;
                            cheque[1] = j;
                            cheque[2] = k;
                            isStop = true;
                            ShowMSG(cheque);
                            break;
                        }
                        else if (i == input.Max() && j == input.Max() && k == input.Max())
                        {
                            System.Console.WriteLine("Can't find cheques");
                        }
                    }
                }
            }
        }

        private static bool IsCheck(int input, int i, int j, int k)
        {
            return input == i || input == j || input == k || input == i + j || input == i + k || input == j + k || input == i + j + k;
        }

        private static void ShowMSG(int[] cheque)
        {
            System.Console.WriteLine("You shold write the following cheques");
            for (int i = 0; i < cheque.Length; i++)
            {
                System.Console.WriteLine($"#{i + 1} ${cheque[i]}");
            }
        }
    }
}
