using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
                x *= -1;
            if (y < 0)
                y *= -1;
            if (x < 40)
            {
                if (y < 40)
                    Console.WriteLine("Да");
                else if (y == 40)
                    Console.WriteLine("На грани");
                else
                    Console.WriteLine("Нет");
            }
            else if (x == 40)
            {
                if (y == 40 || y < 40)
                    Console.WriteLine("На грани");
                else
                    Console.WriteLine("Нет");
            }
            else
                Console.WriteLine("Нет");
            Console.ReadLine();
        }
    }
}
