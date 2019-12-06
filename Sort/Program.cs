using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList integers =
                new ArrayList { 1, 2, -5, 0, 89, 4, -5, 100, 9};

            ArrayList doubles =
                new ArrayList { 1.09, 6.5, 6.0, 2, -5.99, 0, 89.1, 4, -5, 100.555, 9 };

            ArrayList strings =
                new ArrayList { "Юлия", "John", "Bill", "Ivan", "Maria", "Katerina", "Иван", "Алексей" };

            // IntSort.SortAsc(integers);

            // Sort.UniversalSort(integers, Program.IntCompareDescRule);
            // Sort.UniversalSort(integers, (a, b) => (int)b - (int)a);
            // Sort.UniversalSort(doubles, (a, b) => (double)a - (double)b);
            // Sort.UniversalSort(strings, (a, b) => ((string)b).CompareTo((string)a));

            ArrayList goods =
                new ArrayList {
                    new Good { id = 1, title = "abc", price = 100000.99m },
                    new Good { id = 2, title = "zxc", price = 1000.09m },
                    new Good { id = 5, title = "abc", price = 10.99m },
                    new Good { id = 3, title = "lojhkgfhk", price = 9.05m },
                    new Good { id = 4, title = "reweyt", price = 100500m }
                };

            Sort.UniversalSort(goods, (a, b) => ((Good)a).title.CompareTo(((Good)b).title), (a,b) => ((Good)a).price.CompareTo(((Good)b).price));

            // integers.ForEach(Console.WriteLine);
            foreach (var item in goods)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        static int IntCompareAscRule(dynamic a, dynamic b) {
            return (int)a - (int)b;
        }

        static int IntCompareDescRule(dynamic a, dynamic b)
        {
            return (int)b - (int)a;
        }
    }
}
