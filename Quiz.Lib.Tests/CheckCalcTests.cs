using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace Quiz.Lib.Tests
{
    public class CheckCalcTests
    {
        [Theory]
        [MemberData(nameof(CheckSamples))]
        public void CanPayCheckReturnThePayableSolution(int amount, Cheque[] cheques, ChequeSolution expected)
        {
            var sut = new CheckCalc();
            var result = sut.CanPayCheque(amount, cheques);
            Assert.Equal(expected.Payable, result.Payable);
            result.Cheques.Should().BeEquivalentTo(expected.Cheques);
        }

        [Theory]
        [MemberData(nameof(AmountSamples))]
        public void FindChequesCanReturnTheValidCheques(int[] amounts, Cheque[] expected) {
            var sut = new CheckCalc();
            var result = sut.FindCheques(amounts);
            result.Should().BeEquivalentTo(expected);
        }

        public static IEnumerable<object[]> CheckSamples = new List<object[]>() {
            new object[] {
                40,
                new Cheque[] { new Cheque("#1", 10), new Cheque("#2", 30), new Cheque("#3", 50)  },
                new ChequeSolution {
                    Payable = true,
                    Cheques = new Cheque[] { new Cheque("#1", 10), new Cheque("#2", 30) },
                },
            },
            new object[] {
                50,
                new Cheque[] { new Cheque("#1", 10), new Cheque("#2", 30), new Cheque("#3", 50)  },
                new ChequeSolution {
                    Payable = true,
                    Cheques = new Cheque[] { new Cheque("#3", 50) },
                },
            },
            new object[] {
                45,
                new Cheque[] { new Cheque("#1", 10), new Cheque("#2", 30), new Cheque("#3", 50)  },
                new ChequeSolution {
                    Payable = false,
                    Cheques = new Cheque[0],
                },
            },
        };

        public static IEnumerable<object[]> AmountSamples = new List<object[]>() {
            new object[] {
                new int[] { 15, 30, 45, 60 },
                new Cheque[] { new Cheque("#1", 15), new Cheque("#2", 15), new Cheque("#3", 30) },
            },
            new object[] {
                new int[] { 50, 51, 53, 60 },
                new Cheque[0],
            },
            new object[] {
                new int[] { 50, 51, 52, 53 },
                new Cheque[] { new Cheque("#1", 1), new Cheque("#2", 2), new Cheque("#3", 50) },
            },
            new object[] {
                new int[] { 15, 20, 25, 30 },
                new Cheque[] { new Cheque("#1", 5), new Cheque("#2", 10), new Cheque("#3", 15) },
            },
        };
    }
}
