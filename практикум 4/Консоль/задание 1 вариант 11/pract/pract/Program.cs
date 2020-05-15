using System;

namespace pract
{
    class Program
    {
        static int f(int n, int m1,int m2,int nx)
        {
            m1 = Math.Abs(m1)-6*m2;
            if (nx != n)
            {
                nx++;
                return f(n, m2, m1, nx);
            }
            else
                return m1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 2)
            {
                Console.WriteLine("ответ: " + f(n, -10, 2, 3));
            }
            else
                Console.WriteLine("Чичло n должно быть больше 2");
            Console.ReadLine();
        }
    }
}
