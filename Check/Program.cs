using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new List<int>();
            for (int i=1;i<=4;i++)
            {
                Console.Write($"Input number {i} : ");
                int num = int.Parse(Console.ReadLine());
                product.Add(num);
            }
            
            var max = product.Max();
            var result = new List<int>();
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    for (int k = 0; k < max; k++)
                    {
                        var checkList = new List<int>();
                        checkList.Add(i);
                        checkList.Add(j);
                        checkList.Add(k);
                        if (SumForProduct(product, checkList))
                        {
                            result = checkList;
                            foreach (var item in result)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            return;
                        }
                    }
                }
            }
        }

        public static bool SumForProduct(List<int> productParam, List<int> checkParam)
        {
            var product = new List<int>();
            var check = new List<int>();
            foreach (var item in productParam)
            {
                product.Add(item);
            }
            foreach (var item in checkParam)
            {
                check.Add(item);
            }

            var productToDelete = new List<int>();
            for (int i = 0; i < product.Count; i++)
            {
                //-----------------------------
                for (int j = 0; j < check.Count; j++)
                {
                    if (CheckOne(product[i], check[j]))
                    {
                        productToDelete.Add(product[i]);
                    }
                }
                //-----------------------------
                if (CheckTwo(product[i], check[0], check[1]))
                {
                    productToDelete.Add(product[i]);
                }
                if (CheckTwo(product[i], check[0], check[2]))
                {
                    productToDelete.Add(product[i]);
                }
                if (CheckTwo(product[i], check[1], check[2]))
                {
                    productToDelete.Add(product[i]);
                }
                //-----------------------------
                if (CheckThree(product[i], check[0], check[1], check[2]))
                {
                    productToDelete.Add(product[i]);
                }
            }
            if (productToDelete.Count !=0)
            {
                foreach (var item in productToDelete)
                {
                    product.Remove(item);
                }
            }
            if (product.Count == 0)
            {
                return true;
            }
            return false;


        }


        public static bool CheckOne(int product, int check)
        {
            return product == check;
        }
        public static bool CheckTwo(int product, int check1, int check2)
        {
            return product == check1 + check2;
        }
        public static bool CheckThree(int product, int check1, int check2, int check3)
        {
            return product == check1 + check2 + check3;
        }
    }
}
