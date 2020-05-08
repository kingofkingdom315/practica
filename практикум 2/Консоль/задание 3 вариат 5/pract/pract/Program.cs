using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Введие А");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введие B");
            B = Convert.ToInt32(Console.ReadLine());
            if (A < B)
            {
                Console.WriteLine("For");
                int s, g = 0;
                s = A;
                for (int i = 0; i <= B - A; i++)
                {
                    if (s % 2 == 0 && s != 0 && s % 10 != 0)
                    {
                        Console.WriteLine(s);
                    }
                    s++;
                }
                Console.WriteLine("While");
                s = A;
                while (s <= B)
                {
                    if (s % 2 == 0 && s != 0 && s % 10 != 0)
                    {
                        Console.WriteLine(s);
                    }
                    s++;
                }
                Console.WriteLine("Do While");
                s = A;
                do
                {
                    if (s % 2 == 0 && s != 0 && s % 10 != 0)
                    {
                        Console.WriteLine(s);
                    }
                    s++;
                }
                while (s <= B);
            }
            else
            {
                Console.WriteLine("A должно быть меньше B");
            }
            Console.ReadLine();
        }
    }
}
