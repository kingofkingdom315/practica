using System;
using System.Text.RegularExpressions;

namespace pract
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введиет S");
            String s = Console.ReadLine();
            Regex reg = new Regex(@"\b[0-9]{2}-[0-9]{2}-[0-9]{2}\b");
            Regex reg1 = new Regex(@"\b[0-9]{3}-[0-9]{3}\b");
            Regex reg2 = new Regex(@"\b[0-9]{3}-[0-9]{2}-[0-9]{2}\b");
            MatchCollection matches = reg.Matches(s);
            if(matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            matches = reg1.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            matches = reg2.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.ReadLine();
        }
    }
}

