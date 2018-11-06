using System;
using System.Collections.Generic;
using System.Linq;

namespace ___Cheque
{
    class Program
    {
        static void Main(string[] args)
        {
            var chequeList = new List<int>();
            var priceList = new List<int>();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Enter amount #{i}:");
                var priceStr = Console.ReadLine();
                var isInt = int.TryParse(priceStr, out var price);
                if (!isInt || price == 0)
                {
                    Console.WriteLine("Data have error or price is 0, plsease start again.");
                    Console.ReadKey();
                    return;
                }
                priceList.Add(price);
            }
            var ingorePrice = 99;
            priceList = priceList.OrderBy(it => it).ToList();

            var isIngorePriceIndex0 = priceList[0] == priceList[1];
            var isIngorePriceIndex2 = priceList[1] == priceList[2]
                || priceList[0] + priceList[1] == priceList[2];
            var isIngorePriceIndex3 = priceList[0] + priceList[1] + priceList[2] == priceList[3]
                || priceList[0] + priceList[1] == priceList[3]
                || priceList[0] + priceList[2] == priceList[3]
                || priceList[1] + priceList[2] == priceList[3]
                || priceList[2] == priceList[3];

            var threeChequePayAble = isIngorePriceIndex0 || isIngorePriceIndex2 || isIngorePriceIndex3;
            if (!threeChequePayAble)
            {
                var shareCheque = 1;
                for (int i = 2; i < priceList[0]; i++)
                {
                    var isShareNumber = priceList[0] % i == 0
                        && priceList[1] % i == 0
                        && priceList[2] % i == 0
                        && priceList[3] % i == 0;
                    if (isShareNumber) shareCheque = i;
                }
                priceList[0] -= shareCheque;
                priceList[1] -= shareCheque;
                priceList[2] -= shareCheque;
                priceList[3] -= shareCheque;

                isIngorePriceIndex0 = priceList[0] == priceList[1];
                isIngorePriceIndex2 = priceList[1] == priceList[2]
                    || priceList[0] + priceList[1] == priceList[2];
                isIngorePriceIndex3 = priceList[0] + priceList[1] + priceList[2] == priceList[3]
                    || priceList[0] + priceList[1] == priceList[3]
                    || priceList[0] + priceList[2] == priceList[3]
                    || priceList[1] + priceList[2] == priceList[3]
                    || priceList[2] == priceList[3];
                threeChequePayAble = isIngorePriceIndex0 || isIngorePriceIndex2 || isIngorePriceIndex3;

                if (!threeChequePayAble)
                {
                    Console.WriteLine("Can't find 3 cheques for all those amounts.");
                    return;
                }
            }
            ingorePrice = isIngorePriceIndex0 ? 0
                : isIngorePriceIndex2 ? 2
                : 3;

            for (int i = 0; i < 4; i++)
            {
                if (ingorePrice != i) chequeList.Add(priceList[i]);
            }

            Console.WriteLine("You should write the following cheques");
            for (int i = 0; i < chequeList.Count; i++)
            {
                Console.WriteLine($"#{i + 1} ${chequeList[i]}");
            }
            Console.ReadKey();
        }
    }
}