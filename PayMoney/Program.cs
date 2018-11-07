using System;
using System.Collections.Generic;

namespace PayMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[4];
            List<string> list = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine($"Enter amount #{i + 1}:");
                list.Add(Console.ReadLine());
                //System.Console.WriteLine("Hi : " + input[i]);

            }
            list.Sort();
            int j = 0;
            foreach (string value in list)
            {
                input[j] = int.Parse(value);
                // Console.WriteLine("0" + value);
                // System.Console.WriteLine(input[j]);
                j++;
            }

            System.Console.WriteLine("You shold write the following cheques");
            System.Console.WriteLine(gcd(input));

        }

        public static int gcd(int[] number)
        {
            int result = 1;
            int num = 2;
            int min = number[0];
            while (num < min)
            {
                // && number[1] % num == 0 && number[2] % num == 0 && number[3] % num == 0
                if (number[0] % num == 0)
                { // เช็คว่าหารทั้งสองตัวลงตัว
                    //int i = 0;
                    result = num * result;
                    number[0] = number[0] / num;
                    number[1] = number[1] / num;
                    number[2] = number[2] / num;
                    number[3] = number[3] / num;
                    num = 1;
                    System.Console.WriteLine(result);
                }
                num++;
            }
            return result;
        }
    }
}
