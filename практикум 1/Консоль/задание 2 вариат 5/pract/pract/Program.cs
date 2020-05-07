using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Введите число А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите двухзначое число");
            B = Convert.ToInt32(Console.ReadLine());
            B = (B / 10) + (B % 10);
            if (B % A == 0)
                Console.WriteLine("Кратно");
            else
                Console.WriteLine("Не кратно");
            Console.ReadLine();
        }
    }
}
