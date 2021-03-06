using System;
using System.Security.Cryptography.X509Certificates;

namespace Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество прямоугольников ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] A = new double[4];
            double[] B = new double[4];
            Rectangle[] a = new Rectangle[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Заволните данные о прямоугольнике " + (i + 1));
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("точка " + (j + 1) + ". x = ");
                    A[j] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("y = ");
                    B[j] = Convert.ToDouble(Console.ReadLine());
                }
                a[i] = new Rectangle(A, B);
            }
            a[0].outFigure(a[0].x, a[0].y,a[0].S(),a[0].FigureP(a[0].x,a[0].y));
            a[0].outRectangle();
            Console.Write("Введите количество триугольников ");
            n = Convert.ToInt32(Console.ReadLine());
            Triangle[] b = new Triangle[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Заволните данные о триугольние " + (i + 1));
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("точка " + (j + 1) + ". x = ");
                    A[j] = Convert.ToDouble(Console.ReadLine());
                    Console.Write("y = ");
                    B[j] = Convert.ToDouble(Console.ReadLine());
                }
                b[i] = new Triangle(A, B);
            }
            b[0].outFigure(b[0].x, b[0].y, b[0].S(), b[0].FigureP(b[0].x, b[0].y));
            b[0].outTriangle();
            Console.Write("Введите количество окружностей ");
            n = Convert.ToInt32(Console.ReadLine());
            Circle[] z = new Circle[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Заволните данные о триугольние " + (i + 1));
                Console.Write("Центр. x = ");
                A[0] = Convert.ToDouble(Console.ReadLine());
                Console.Write("y = ");
                B[0] = Convert.ToDouble(Console.ReadLine());
                Console.Write("R = ");
                A[1] = Convert.ToDouble(Console.ReadLine());
                z[i] = new Circle(A[0], B[0], A[1]);
            }
            z[0].outCircle();
            Console.ReadKey();
        }
    }
}
