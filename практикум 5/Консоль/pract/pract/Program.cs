using System;

namespace pract
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if (x == 2) throw new Exception();
                else if (x == 0) throw new Exception();
                else return Math.Log(x/(x-2),Math.E);
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введиет a = ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b = ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введиет h = ");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y(" + i + ") = " + f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y("+ i +") = ошибка");
                    }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}

