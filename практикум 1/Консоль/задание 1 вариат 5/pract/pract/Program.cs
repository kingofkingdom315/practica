using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c;
            Console.WriteLine("Введите катит а");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите катит b");
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Гипотенуза с = " + c);
            Console.ReadLine();
        }
    }
}
