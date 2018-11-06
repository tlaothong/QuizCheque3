using System;
using System.Linq;
using System.Collections.Generic;

namespace sorry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] amount = new int[4];
            Console.WriteLine("Enter amount #1:");
            amount[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount #2:");
            amount[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount #3:");
            amount[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount #4:");
            amount[3] = int.Parse(Console.ReadLine());

            int[] check = new int[3];
            var min = amount.Min(it => it);
            for (int i = 0; i < amount.Length; i++)
            {
                int j = 0;
                if (amount[i] - min != 0)
                {
                    check[j] = amount[i] - min;
                    j++;
                }
            }

            if (check == null)
            {
                Console.WriteLine("You should write the following cheques");
            }
            else
            {
                foreach (var item in check)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
