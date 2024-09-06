using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsseseisevToo
{
    public static class Funct2
    {
        public static void Matrix(int size, int minNumber, int maxNumber)
        {
            Random rand = new Random();
            int[,] matrix = new int[size, size];

            int positive = 0;
            int negative = 0;

            for (int i = 0; i < size; i++)
            {
                for (int l = 0; l < size; l++)
                {
                    matrix[i, l] = rand.Next(minNumber, maxNumber + 1);

                    if (matrix[i, l] > 0)
                    {
                        positive++;
                    }
                    else if (matrix[i, l] < 0)
                    {
                        negative++;
                    }
                }
                Console.WriteLine(); // Liikugun pärast iga maatriksi rida uuele reale
            }
            Console.WriteLine($"positiivseid {positive}");
            Console.WriteLine($"negatiivsed elemendid {negative}");
            for (int i = 0; i < size; i++)
            {
                for (int l = 0; l < size; l++)
                {
                    if (matrix[i, l] == 0)
                    {
                        Console.WriteLine($"null on {i} reast ja veerust {l}");
                    }
                }
            }
        }
    }
}   
