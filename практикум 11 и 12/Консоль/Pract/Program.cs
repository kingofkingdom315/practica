using System;

namespace Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(-5,12);
            a.cordout();
            Console.WriteLine(a.XO());
            a.moving(5, -12);
            a.cordout();
            a.cordx = 6;
            Console.WriteLine(a.cordx);
            a.cordy = 6;
            Console.WriteLine(a.cordy);
            a.cordout();
            a.Scal = 4;
            a.cordout();
            a++;
            a.cordout();
            a = a + 3;
            a.cordout();
            Console.ReadKey();
        }
    }
}
