using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount #1");
            string input1 = Console.ReadLine();
            int a = int.Parse(input1);
            Console.WriteLine("Enter amount #2");
            string input2 = Console.ReadLine();
            int b = int.Parse(input2);
            Console.WriteLine("Enter amount #3");
            string input3 = Console.ReadLine();
            int c = int.Parse(input3);
            Console.WriteLine("Enter amount #4");
            string input4 = Console.ReadLine();
            int d = int.Parse(input4);

            int sum = a+b; 

           if(a < b && b-a >= 4)
           {
                System.Console.WriteLine("You shold write the following cheques"); 
                System.Console.WriteLine("#1 $" + sum); 
                System.Console.WriteLine("#2 $" + sum*1); 
                System.Console.WriteLine("#3 $" + sum*2);                                                        

           }

           else
           {
               System.Console.WriteLine("Can't find cheques");
           }


            

        }
    }




}
