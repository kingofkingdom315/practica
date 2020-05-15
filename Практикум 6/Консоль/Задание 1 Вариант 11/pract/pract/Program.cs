using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());
            int r = 0, r1 = 0;
            int[] mas = new int[n];
            int[,] mas1 = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                mas[i] = i;
                Console.WriteLine("mas1[" + i + "] = " + i);
                if (i % 2 == 0)
                {
                    r += mas[i] * mas[i];
                }
            }
            Console.WriteLine("Ответ для одномерного масива = " + r);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas1[i, j] = j;
                    Console.WriteLine("mas1[" + i + "][" + j + "] = " + j + " ");
                    if (i % 2 == 0)
                    {
                        r1 += mas1[i, j] * mas1[i, j];
                    }
                    else if (j % 2 == 0)
                    {
                        r1 += mas1[i, j] * mas1[i, j];
                    }
                }
            }
            Console.WriteLine("Ответ для двумерного масива = " + r1);
            Console.ReadLine();
        }
    }
}
