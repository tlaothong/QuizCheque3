using System;
using Quiz.Lib;

namespace QuizConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CheckCalc();
            var n1 = AskAmount(1);
            var n2 = AskAmount(2);
            var n3 = AskAmount(3);
            var n4 = AskAmount(4);

            var chqs = calc.FindCheques(new int[] { n1, n2, n3, n4 });
            if (chqs.Length == 0)
            {
                Console.WriteLine("Can't find 3 cheques for all those amounts.");
            } else
            {
                Console.WriteLine("You should write the following cheques");
                foreach (var chq in chqs)
                {
                    Console.WriteLine("{0} ${1}", chq.Name, chq.Amount);
                }
                WriteChequesPayFor(n1, calc.CanPayCheque(n1, chqs).Cheques);
                WriteChequesPayFor(n2, calc.CanPayCheque(n2, chqs).Cheques);
                WriteChequesPayFor(n3, calc.CanPayCheque(n3, chqs).Cheques);
                WriteChequesPayFor(n4, calc.CanPayCheque(n4, chqs).Cheques);
            }
        }

        static int AskAmount(int i)
        {
            Console.WriteLine("Enter amount #{0}: ", i);
            var n = Console.ReadLine();
            return int.Parse(n);
        }

        static void WriteChequesPayFor(int n, Cheque[] cheques) {
            Console.WriteLine("For {0}", n);
            foreach (var chqs in cheques)
            {
                Console.WriteLine(" + {0} ${1}", chqs.Name, chqs.Amount);
            }
        }
    }
}
