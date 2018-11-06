using System;
using System.Collections.Generic;
using System.Text;

namespace ChequeFinder.BizDomain
{
    public class ChequeFinderBizDomain : IChequeFinderBizDomain
    {
        public IEnumerable<int> FindCheque(IEnumerable<int> prices)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> FindFactor(int number)
        {
            throw new NotImplementedException();
        }
    }
}
