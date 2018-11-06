using System;

namespace QuizCheque3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[4];
            int[] sortList = new int[4];
            int output1;
            int output2;
            int output3;


            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Enter amount #" + i + ": ");
                list[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(list);

            output1 = list[1];
            
            if (list[1] == list[2] || list[1] == list[3] || list[1] == list[4])
            {
                if (list[1] + list[1] == list[2] || list[1] + list[1] == list[3] || list[1] + list[1] == list[4] ||
                 list[1] + list[1] == list[2] || list[1] + list[1] == list[2])
                {

                }
            }

        }
    }
}
