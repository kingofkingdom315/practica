using System;

namespace pract
{
    class Program
    {
        static void f(int n, int nx)
        {
            if (n % nx == 0 && n != nx)
            {
                Console.WriteLine(nx);
                nx++;
                f(n, nx);
            }
            else if (n != nx)
            {
                nx++;
                f(n, nx);
            }
            else
            {
                Console.WriteLine(n);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                f(n, 1);
            }
            else
            {
                Console.WriteLine("Число должно быть больше 0");
            }
            Console.ReadLine();
        }
    }
}
