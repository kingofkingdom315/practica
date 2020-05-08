using System;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
