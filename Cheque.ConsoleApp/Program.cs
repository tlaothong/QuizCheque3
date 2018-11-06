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

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (input[i] < input[j])
                    {
                        var t = input[i];
                        input[i] = input[j];
                        input[j] = t;
                    }
                }
            }

            int[] cheque = new int[3];
            cheque[0] = input[0];
            cheque[1] = cheque[2] = 0;

            for (int i = 0; i < 3; i++)
            {
                if (input[0] != input[i + 1])
                {
                    cheque[1] = input[i + 1] - input[0];
                    break;
                }
            }

            cheque[2] = input[3] - cheque[1] - cheque[0];

            if (IsMatch(input, cheque))
            {
                ShowMSG(cheque);
            }
            else
            {
                cheque[1] = input[1];
                cheque[2] = input[3] - cheque[1] - cheque[0];
                if (IsMatch(input, cheque))
                {
                    ShowMSG(cheque);
                }
                else
                {
                    System.Console.WriteLine("Can't find cheques");
                }
            }
        }
        
        private static bool IsMatch(int[] input, int[] cheque)
        {
            for (int i = 0; i < 3; i++)
            {
                if (input[2] == cheque[i] || input[2] == cheque[i] + cheque[(i + 1) % 3] || input[2] == cheque[i] + cheque[(i + 2) % 3] || input[2] == cheque.Sum())
                {
                    return true;
                }
            }
            return false;
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
