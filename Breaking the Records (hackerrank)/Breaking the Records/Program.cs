using System;

namespace Breaking_the_Records
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {
            int min = scores[0];
            int max = scores[0];

            int countMin = 0;
            int countMax = 0;

            for (int i=1;i<scores.Length;i++)
            {
                int game = scores[i];

                if ( game > max )
                {
                    max = game;
                    countMax++;
                }
                if (game < min)
                {
                    min = game;
                    countMin++;
                }
            }

            return new int[] { countMax, countMin };
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
