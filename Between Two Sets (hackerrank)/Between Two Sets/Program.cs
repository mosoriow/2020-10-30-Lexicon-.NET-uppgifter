using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Between_Two_Sets
{
    class Result
    {
        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */
        public static int getTotalX(List<int> a, List<int> b)
        {
            int result = 0;
            int maxValue = 0;

            foreach(int bv in b)
            {
                if (bv > maxValue)
                    maxValue = bv;
            }

            for(int test = 1; test <= maxValue; test++)
            {
                bool fillCondition = true;
                foreach(int av in a)
                {
                    if ((test % av) != 0)
                        fillCondition = false;
                }
                if (fillCondition)
                {
                    foreach(int bv in b)
                    {
                        if ((bv % test) != 0)
                            fillCondition = false;
                    }
                }
                if (fillCondition)
                    result++;
            }

            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.getTotalX(arr, brr);

            Console.WriteLine(total);
        }
    }
}
