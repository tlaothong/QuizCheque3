using System;
using System.Collections.Generic;
using System.Linq;
namespace Quiz1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.Write("Enter amount #1 : ");
            var a = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter amount #2 : ");
            var b = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter amount #3 : ");
            var c = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter amount #4 : ");
            var d = Convert.ToInt32(Console.ReadLine());
            var max = new List<int> { a, b, c, d };
            var maxend = max.Max(); ;
            List<int> numbers = new List<int>();
            var index = max.FindIndex(i => i == max.Max());
            if (index >= 0)
            {
                max.RemoveAt(index);
            }
            //Console.WriteLine("index" + index);

            foreach (var x in max)
            {
                for (int i = 0; i < 3; i++)
                {
                    numbers.Add(x);
                }
                //Console.Write("{0} + " + x);
            }
            // เอาค่ามา+กันหาค่า >= max
            foreach (var x in numbers)
            {
                
                Console.Write("E" + x);
                Console.WriteLine();
            }
            Console.WriteLine();



            Console.WriteLine("xxx : " + max.Max());
            Console.WriteLine("xxx : " + maxend);
        }
    }
}
