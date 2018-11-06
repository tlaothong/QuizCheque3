using System;

namespace QuizCheque3
{
    class Program
    {
        static void Main(string[] args)
        {
            int product1, product2, product3, product4, total, pay;
            int check5 = 0, check10 = 0, check15 = 0, check20 = 0, check30 = 0, check40 = 0;

            Console.WriteLine("Enter Amount #1");
            product1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount #2");
            product2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount #3");
            product3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount #4");
            product4 = int.Parse(Console.ReadLine());

            total = product1 + product2 + product3 + product4;
            //  Console.WriteLine(total);
            if (total >= 5)
            {
                check5 = total / 5;
                total %= 5;
                Console.WriteLine("You should write the following cheques");
                System.Console.WriteLine("#1 " + "$5");
            }
            if (total >= 10)
            {
                check10 = total / 10;
                total %= 10;
                System.Console.WriteLine("#2 " + "$10");
            }
            if (total >= 15)
            {
                check40 = total / 15;
                total %= 15;
                System.Console.WriteLine("#3 " + "$15");
            }
            if (total >= 20)
            {
                check20 = total / 20;
                total %= 20;
                System.Console.WriteLine("#4 " + "$20");
            }
            if (total >= 30)
            {
                check30 = total / 30;
                total %= 30;
                System.Console.WriteLine("#5 " + "$30");
            }
            if (total >= 40)
            {
                check40 = total / 40;
                total %= 40;
                System.Console.WriteLine("#5 " + "$40");
            }


        }
    }
}
