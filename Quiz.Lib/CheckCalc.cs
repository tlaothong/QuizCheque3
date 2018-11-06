using System;
using System.Linq;

namespace Quiz.Lib
{
    public class CheckCalc
    {
        public Cheque[] FindCheques(int[] amounts) {
            var maxAmount = Math.Max(amounts[0], Math.Max(amounts[1], amounts[2]));
            for (int i = 0; i < maxAmount; i++)
            {
                for (int j = 0; j < maxAmount; j++)
                {
                    for (int k = 0; k < maxAmount; k++)
                    {
                        var cheques = new Cheque[] {
                            new Cheque("#1", i),
                            new Cheque("#2", j),
                            new Cheque("#3", k),
                        };
                        if (amounts.All(it => CanPayCheque(it, cheques).Payable)) {
                            return cheques;
                        }
                    }
                }
            }
            return new Cheque[0];
        }

        public ChequeSolution CanPayCheque(int amount, Cheque[] cheques)
        {
            var searchPatterns = new Cheque [][] {
                new [] { cheques[0] },
                new [] { cheques[1] },
                new [] { cheques[2] },
                new [] { cheques[0], cheques[1] },
                new [] { cheques[0], cheques[2] },
                new [] { cheques[1], cheques[2] },
                new [] { cheques[0], cheques[1], cheques[2] },
            };

            foreach (var pattern in searchPatterns)
            {
                if (amount == pattern.Sum(it => it.Amount))
                {
                    return new ChequeSolution {
                        Payable = true,
                        Cheques = pattern,
                    };
                }
            }

            return new ChequeSolution
            {
                Payable = false,
                Cheques = new Cheque[0],
            };
        }
    }

    public class ChequeSolution
    {
        public bool Payable { get; set; }
        public Cheque[] Cheques { get; set; }
    }

    public class Cheque
    {
        public Cheque(string name, int amount)
        {
            this.Name = name;
            this.Amount = amount;
        }

        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
