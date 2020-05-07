using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Введите месяцы");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите дни");
            n = Convert.ToInt32(Console.ReadLine());
            switch (m%12)
            {
                case 0:
                    Console.WriteLine("Январь");
                    break;
                case 1:
                    Console.WriteLine("Февраль");
                    break;
                case 2:
                    Console.WriteLine("Март");
                    break;
                case 3:
                    Console.WriteLine("Апрель");
                    break;
                case 4:
                    Console.WriteLine("Май");
                    break;
                case 5:
                    Console.WriteLine("Июнь");
                    break;
                case 6:
                    Console.WriteLine("Июль");
                    break;
                case 7:
                    Console.WriteLine("Август");
                    break;
                case 8:
                    Console.WriteLine("Сентябрь");
                    break;
                case 9:
                    Console.WriteLine("Октябрь");
                    break;
                case 10:
                    Console.WriteLine("Ноябрь");
                    break;
                case 11:
                    Console.WriteLine("Декабрь");
                    break;
            }
            Console.ReadLine();
        }
    }
}
