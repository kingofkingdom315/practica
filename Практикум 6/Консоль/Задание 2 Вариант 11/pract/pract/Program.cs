using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            int max = -100000, min = 1000000, x = 0, y = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("mas[" + i + "] = ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
                if (mas[i] >= max)
                {
                    x = i;
                    max = mas[i];
                }
                else if (mas[i] <= min)
                {
                    y = i;
                    min = mas[i];
                }
            }
            max = 0;
            if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    max += mas[i];
                }
                Console.WriteLine("Ответ = " + max);
            }
            else
            {
                Console.WriteLine("Максимальный элемент находится после минммального");
            }
            Console.ReadLine();
        }
    }
}
