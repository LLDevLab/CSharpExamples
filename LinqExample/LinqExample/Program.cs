using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine($"For loop result: {string.Join(',', ForLoopGetGreaterThan(1))}");
            Console.WriteLine($"ForEach loop result: {string.Join(',', ForEachLoopGetGreaterThan(2))}");
            Console.WriteLine($"ForEach loop result: {string.Join(',', ForEachWithFuncGetGreaterThan(3))}");
            Console.WriteLine($"Linq 1 result: {string.Join(',', LinqWithFuncGetGreaterThan(4))}");
            Console.WriteLine($"Linq 2 result: {string.Join(',', LinqWithLambdaGetGreaterThan(5))}");
            Console.WriteLine($"Linq 3 result: {string.Join(',', LinqWithQueryGetGreaterThan(6))}");

            List<string> ForLoopGetGreaterThan(int num)
            {
                var result = new List<string>();
                for (int i = 0; i < list.Count; i++)
                {
                    var elem = list[i];
                    if (elem > num)
                        result.Add(elem.ToString());
                }
                return result;
            }

            List<string> ForEachLoopGetGreaterThan(int num)
            {
                var result = new List<string>();
                foreach (var elem in list)
                {
                    if (elem > num)
                        result.Add(elem.ToString());
                }
                return result;
            }

            List<string> ForEachWithFuncGetGreaterThan(int num)
            {
                var result = new List<string>();
                foreach (var elem in list)
                {
                    if (isGreater(elem))
                        result.Add(getString(elem));
                }
                return result;

                bool isGreater(int curNum)
                {
                    return curNum > num;
                }

                string getString(int curNum)
                {
                    return curNum.ToString();
                }
            }

            List<string> LinqWithFuncGetGreaterThan(int num)
            {
                return list
                    .Where(isGreater)
                    .Select(getString)
                    .ToList();

                bool isGreater(int curNum)
                {
                    return curNum > num;
                }

                string getString(int curNum)
                {
                    return curNum.ToString();
                }
            }

            List<string> LinqWithLambdaGetGreaterThan(int num)
            {
                return list
                    .Where(curNum => curNum > num)
                    .Select(curNum => curNum.ToString())
                    .ToList();
            }

            List<string> LinqWithQueryGetGreaterThan(int num)
            {
                return (from curNum in list
                       where curNum > num
                       select curNum.ToString()).ToList();
            }
        }
    }
}
