using System;

namespace pract
{
    class Program
    {
        static double f(Double x)
        {
            double y;
            if (x <= 5)
                y = x * x + 5;
            else if (x < 20)
                y = 0;
            else
                y = 1;
            return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите H");
            double h = Convert.ToDouble(Console.ReadLine());
            if (a < b)
                for (Double i = a; i <= b; i += h)
                    Console.WriteLine("f(" + i + ") = " + f(i));
            else
            {
                Console.WriteLine("A должно быть меньше B");
            }
            Console.ReadLine();
        }
    }
}
