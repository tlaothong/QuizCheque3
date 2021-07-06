using System;
using System.Collections.Generic;
using System.Linq;

namespace demoCheque
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listChecque = new List<int>(3);
            listChecque.Add(0);
            listChecque.Add(0);
            listChecque.Add(0);
            List<int> listPrice = new List<int>();
            listPrice.Add(3);
            listPrice.Add(6);
            listPrice.Add(7);
            listPrice.Add(10);
            //check 1
            listChecque[0] = listPrice[0];
            //check 2
            if(listPrice[1]% listChecque[0] == 0)
            {
                int cheque2 = 0;
                for (int i = 0; i < 99; i++)
                {
                    cheque2 = listChecque[0];
                    if (listChecque[0]*i == listPrice[1])
                    {
                        
                    }
                }
            }



            Console.ReadLine();
        }
    }
}
