using System;
using System.IO;

namespace pract
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            string text = System.IO.File.ReadAllText("f.txt");
            string[] s = text.Split("\n");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length == n+1)
                {
                    Console.WriteLine(s[i]);
                }
            }
            Console.ReadLine(); 
        }
    }
}