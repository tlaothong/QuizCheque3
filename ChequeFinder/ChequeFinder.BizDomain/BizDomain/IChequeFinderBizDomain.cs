using System;
using System.Collections.Generic;
using System.Text;

namespace ChequeFinder.BizDomain
{
    public interface IChequeFinderBizDomain
    {
        IEnumerable<int> FindCheque(IEnumerable<int> prices);
        IEnumerable<int> FindFactor(int number);
    }
}
