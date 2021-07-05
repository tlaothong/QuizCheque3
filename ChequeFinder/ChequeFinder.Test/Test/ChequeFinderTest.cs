using ChequeFinder.BizDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChequeFinder.Test
{
    public class ChequeFinderTest
    {
        public static IEnumerable<object[]> scenarios = new List<object[]>
        {
            new object[] { new List<int>{ 15, 30, 45, 60, }, new List<int> { } },
            new object[] { new List<int>{ 50, 51, 53, 59, }, new List<int> { } },
            new object[] { new List<int>{ 20, 40, 60, 80, }, new List<int> { } },
            new object[] { new List<int>{ 20, 15 ,35 ,25, }, new List<int> { } },
            new object[] { new List<int>{ 45 ,30, 15, 20, }, new List<int> { } },
            new object[] { new List<int>{ 15, 20, 25, 30, }, new List<int> { } },
        };

        [Theory]
        [MemberData(nameof(scenarios))]
        public void Test(List<int> amounts)
        {
            var sut = new ChequeFinderBizDomain();
            var cheques = sut.FindCheque(amounts);
        }
    }
}
