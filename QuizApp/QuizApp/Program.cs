using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int InputCount = 4;
            var numbers = new int[InputCount];
            for (int i = 0; i < InputCount; i++)
            {
                Console.Write($"Input {i+1}: " );
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            var max = numbers.Max(it => it);
            var numberRange = Enumerable.Range(1, max).ToList();
            var allPossibles = new List<List<int>>();
            for (int i = 0; i < numberRange.Count - 2; i++)
            {
                for (int j = i + 1; j < numberRange.Count - 1; j++)
                {
                    for (int k = j + 1; k < numberRange.Count; k++)
                    {
                        allPossibles.Add(new List<int> { numberRange[i], numberRange[j], numberRange[k] });
                    }
                }
            }

            var resultCombination = allPossibles.FirstOrDefault(s =>
            {
                var isCorrect = false;
                foreach (var n in numbers)
                {
                    var any = s.Any(it => it == n);
                    var total = s.Sum() == n;
                    var combine1 = s[0] + s[1] == n;
                    var combine2 = s[1] + s[2] == n;
                    var combine3 = s[0] + s[2] == n;
                    var result = any || total || combine1 || combine2 || combine3;
                    if (!result) return false;
                    else isCorrect = true;
                }

                return isCorrect;
            });

            Console.WriteLine("--RESULT--");
            if (resultCombination == null)
            {
                Console.WriteLine("No result");
            }
            else
            {
                foreach (var item in resultCombination)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
