using System;

namespace pract
{
    class Program
    { 
        static void Main(string[] args)
        {
            string s,b;
            Console.WriteLine("Введите s");
            s = Console.ReadLine();
            b = s.Replace(",", " ");
            b = b.Replace(".", " ");
            b = b.Replace("?", " ");
            b = b.Replace("!", " ");
            for (int i = 0; i < b.Length; i++)
                b = b.Replace("  ", " ");
            string[] s1 = b.Split(" ");
            s = s1[0];
            for (int i = 1; i < s1.Length; i++)
                if (s.Length < s1[i].Length)
                    s = s1[i];
                else if (s.Length == s1[i].Length)
                    s += ", " + s1[i];
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}

