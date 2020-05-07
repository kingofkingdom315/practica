using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, x2, x3, y1, y2, y3, S;
            Console.WriteLine("Введите x1");
            x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1");
            y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2");
            y2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите x3");
            x3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите y3");
            y3 = float.Parse(Console.ReadLine());
            S = ((x2 - x1)*(y3 - y1)) - ((x3 - x1)*(y2 - y1));
            if (S < 0)
                S *= -1;
            Console.WriteLine("Площядь = " + S/2);
            Console.ReadLine();
        }
    }
}
