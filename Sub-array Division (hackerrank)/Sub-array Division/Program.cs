using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Sub_array_Division
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {
            int total = 0;

            for(int i = 0; i < s.Count - m+1; i++)
            {
                int sum = 0;
                for(int j = 0; j < m; j++)
                    sum += s[i + j];
                if (sum == d)
                    total++;
            }

            return total;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);
        }
    }
}
