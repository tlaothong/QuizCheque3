using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChequeFinder.BizDomain
{
    public class ChequeFinderBizDomain : IChequeFinderBizDomain
    {
        public IEnumerable<int> FindCheque(List<int> amounts)
        {
            var cheques = new List<int>();
            var minValue = amounts.Min();
            var amountsExcludeMinValue = amounts.OrderBy(x => x).Skip(1);
            foreach (var amount in amountsExcludeMinValue)
            {
                cheques.Add(amount - minValue);
            }

            var canPayMinByCheques = CanPayByCheques(cheques, minValue);
            if (!canPayMinByCheques && cheques[0] + cheques[1] == cheques[2])
            {
                cheques[2] = minValue;
            }

            var isAllCorrect = true;
            foreach (var amount in amounts)
            {
                isAllCorrect &= CanPayByCheques(cheques, amount);
            }

            if (isAllCorrect)
                return cheques;
            else
                return Enumerable.Empty<int>();
        }

        public bool CanPayByCheques(List<int> cheques, int amount)
        {
            return cheques.Any(x => x == amount)
                || cheques[0] + cheques[1] == amount
                || cheques[0] + cheques[2] == amount
                || cheques[1] + cheques[2] == amount
                || cheques[0] + cheques[1] + cheques[2] == amount;
        }
    }
}
