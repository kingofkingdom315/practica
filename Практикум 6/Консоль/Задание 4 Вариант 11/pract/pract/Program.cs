using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n,n];
            int[,] masr = new int[n, 3];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("mas ["+(i+1)+"]["+(j+1)+"] = ");
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (mas[i, j] % 2 != 0)
                    {
                        masr[j, 0] = mas[i, j];
                        masr[j, 1] = i + 1;
                        masr[j, 2] = j + 1;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(masr[i, 0] + " i = " + masr[i, 1] + " j = " + masr[i, 2]);
            }
            Console.ReadLine();
        }
    }
}
