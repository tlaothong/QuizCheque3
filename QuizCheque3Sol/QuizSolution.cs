using System;

namespace QuizCheque3Sol
{
    class QuizSolution
    {
        public static void Main(string[] args)
        {
            string input;
            int a1, a2, a3, a4;
            int c1, c2, c3, cAll;
            int max, min;

            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter amount #1: ");
            a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount #2: ");
            a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount #3: ");
            a3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount #4: ");
            a4 = int.Parse(Console.ReadLine());

            min = Math.Min(a1, Math.Max(a2, Math.Max(a3, a4)));
            max = Math.Max(a1, Math.Max(a2, Math.Max(a3, a4)));
            
            c1 = min;
            c2 = min;
            c3 = max/min;

            cAll = c1 + c2 + c3;

            if (cAll <= max)
            {
                Console.WriteLine("You should write the following cheques");
                Console.WriteLine("#1 " + c1);
                Console.WriteLine("#2 " + c2);
                Console.WriteLine("#3 " + c3);

            }
            else
            {
                Console.WriteLine("Can't find 3 cheques for all those amounts.");
            }


        }
    }
}
