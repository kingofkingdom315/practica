using System;

namespace pract
{
    class Program
    { 
        static void Main(string[] args)
        {
            string s;
            int a = 0;
            Console.WriteLine("Введите s");
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 48 && s[i] <= 57)
                {
                    a += Convert.ToInt32(Convert.ToString(s[i]));
                }
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

