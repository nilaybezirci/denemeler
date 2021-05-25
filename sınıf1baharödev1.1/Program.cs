using System;

namespace sınıf1baharödev1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] satrancTahtasi = new int[8, 8];
            Random rastgele = new Random();
            int[] kaleninkonumuX = new int[8];
            int[] kaleninkonumuY = new int[8];
            int kX;
            int kY;

            int m = 0;
            while (m < 8)
            {
                kX = rastgele.Next(1, 9);
                if (Array.IndexOf(kaleninkonumuX, kX) == -1)
                {
                    kaleninkonumuX[m] = kX;
                    m++;
                }
            }

            m = 0;
            while (m < 8)
            {
                kY = rastgele.Next(1, 9);
                if (Array.IndexOf(kaleninkonumuY, kY) == -1)
                {
                    kaleninkonumuY[m] = kY;
                    m++;
                }
            }


            for (int a = 0; a < 8; a++)
            {
                Console.WriteLine("X:" + kaleninkonumuX[a] + "  Y:" + kaleninkonumuY[a]);
                for (int b = 0; b < 8; b++)
                {
                    for (int c = 0; c < 8; c++)
                    {
                        if (kaleninkonumuY[a] == b + 1 && kaleninkonumuX[a] == c + 1)
                        {
                            satrancTahtasi[b, c] = 1;

                        }
                        Console.Write(satrancTahtasi[b, c]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
