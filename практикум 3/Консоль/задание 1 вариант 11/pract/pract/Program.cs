using System;

namespace pract
{
    class Program
    {
        static void f(int a)
        {
            int b, x, y, z;
            if (a >= 10)
            {
                b = a;
                z = 0;
                while (b > 10)
                {
                    b = b / 10;
                    z++;
                }
                x = a / Convert.ToInt32(Math.Pow(10, Convert.ToDouble(z)));
                y = a % 10;
                b = y * Convert.ToInt32(Math.Pow(10, Convert.ToDouble(z))) + a % Convert.ToInt32(Math.Pow(10, Convert.ToDouble(z)));
                b = b / 10 * 10 + x;
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Нужно минимум двухзначное и положительное число");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            f(a);
            Console.ReadLine();
        }
    }
}
