using System;

namespace Cheque
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int round = 0;
            int[] number = new int[4];
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 4; i++)
            {
                round++;
                Console.Write("Enter amount #" + (round) + " : ");
                number[i] = int.Parse(Console.ReadLine());
                sum = sum + number[i];
            }
            Console.WriteLine("You shold write the following cheques");
            Console.WriteLine("$"+sum);

            //Console.WriteLine("Can't find cheques");
        }
                
    }
}
