using System;
using System.Collections.Generic;

namespace QuizCheque3
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] costProduct = new int[4];
            int[] cheque = new int[3];

            for (int i = 0; i < costProduct.Length; i++)
            {
                Console.WriteLine("Cost Product #" + (i + 1) + ": ");
                costProduct[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(costProduct);

            cheque[0] = costProduct[0];
            cheque[1] = costProduct[3] - costProduct[2];
            cheque[2] = costProduct[3] - (cheque[1] + cheque[0]);

            if (costProduct[0] == costProduct[1] && costProduct[0] == costProduct[2]  && costProduct[0] == costProduct[3] 
            && costProduct[1] == costProduct[2] && costProduct[1] == costProduct[3] && costProduct[2] == costProduct[3]) {
                cheque[0] = costProduct[0];
                cheque[1] = costProduct[1];
                cheque[2] = costProduct[2];

            }

            if (costProduct[3] == costProduct[2] + costProduct[1] + costProduct[0]) {
                
            }
            for (int i = 0 ; i < cheque.Length ; i ++) {
                // cheque[i] = costProduct[i];
                 Console.WriteLine("cheque #" + (i+1) + " : " + cheque[i] + "\n");
            }







        }
    }
}
