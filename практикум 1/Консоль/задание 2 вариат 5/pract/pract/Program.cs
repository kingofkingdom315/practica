using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, D;
            Console.WriteLine("Введите а");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToInt32(Console.ReadLine());
            if (a != 0)
            {
                D = b * b - 4 * a * c;
                if (D > 0)
                    Console.WriteLine("Решения есть");
                else
                    Console.WriteLine("Решения нет");
            }
            else
                Console.WriteLine("Решения нет");
        }
    }
}
