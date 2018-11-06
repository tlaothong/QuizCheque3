using ChequeFinder.BizDomain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChequeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int amountCount = 4;
                var amounts = new List<int>();
                for (int i = 1; i <= amountCount;)
                {
                    Console.Write($"Enter amount #{i}:");
                    if (int.TryParse(Console.ReadLine(), out int amount))
                    {
                        amounts.Add(amount);
                        i++;
                    }
                    else
                    {
                        Console.Write($"Not a number.");
                    }
                }
                var biz = new ChequeFinderBizDomain();
                var cheques = biz.FindCheque(amounts);
                if (cheques.Any())
                {
                    Console.WriteLine("You should write the following cheques");
                    for (int i = 0; i < cheques.Count(); i++)
                    {
                        Console.WriteLine($"#{i + 1} ${cheques.ElementAt(i)}");
                    }
                }
                else
                {
                    Console.WriteLine("Can't find 3 cheques for all those amounts.");
                }
                Console.WriteLine("\n--------------------\n");
            }
        }
    }
}
