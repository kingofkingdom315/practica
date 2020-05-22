using System;
using System.IO;

namespace pract
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            double n = double.Parse(Console.ReadLine());
            FileStream f = new FileStream("f.dat",FileMode.Open);
            BinaryWriter fOut = new BinaryWriter(f);
            double a;
            for (Double i = 0; i < n; i++)
            {
                Console.WriteLine("Введите число");
                a = double.Parse(Console.ReadLine());
                fOut.Write(a);
            }
            fOut.Close();
            f = new FileStream("f.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long m = f.Length;
            for (long i = 0; i < m; i += 8)
            {
                f.Seek(i, SeekOrigin.Begin);
                a = fIn.ReadDouble();
                if (a < 0)
                Console.Write("{0:f2} ", a);
            }
            fIn.Close();
            f.Close();
            Console.ReadLine(); 
        }
    }
}

