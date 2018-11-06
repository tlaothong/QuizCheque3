using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Price1 = null;
            string Price2 = null;
            string Price3 = null;
            string Price4 = null;
            int amount1 = 0;
            int amount2 = 0;
            int amount3 = 0;
            int amount4 = 0;
            int Total = 0;
            int cheques = 0;
            int cheques1 = 0;
            int cheques2 = 0;
            int cheques3 = 0;
            int cheques4 = 0;

            Console.WriteLine("Enter amount #1:");
            Price1 = Console.ReadLine();
            Console.WriteLine("Enter amount #2:");
            Price2 = Console.ReadLine();
            Console.WriteLine("Enter amount #3:");
            Price3 = Console.ReadLine();
            Console.WriteLine("Enter amount #4:");
            Price4 = Console.ReadLine();

            amount1 = Int32.Parse(Price1);
            amount2 = Int32.Parse(Price2);
            amount3 = Int32.Parse(Price3);
            amount4 = Int32.Parse(Price4);

            Total = amount1 + amount2 + amount3 + amount4;
            Console.WriteLine(Total);

            Console.WriteLine("You shold write the following cheques");
            Console.WriteLine("#1 " + cheques1);
            Console.WriteLine("#2 " + cheques2);
            Console.WriteLine("#3 " + cheques);
        }
    }
}
