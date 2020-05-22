using System;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("c:\\temp"))
            {
                Directory.CreateDirectory("c:\\temp");
            }
            Directory.CreateDirectory("c:\\temp\\K1");
            Directory.CreateDirectory("c:\\temp\\K2");
            StreamWriter sw = new StreamWriter("c:\\temp\\K1\\t1.txt");
            sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            sw.Close();
            sw = new StreamWriter("c:\\temp\\K1\\t2.txt");
            sw.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            sw.Close();
            sw = new StreamWriter("c:\\temp\\K2\\t3.txt");
            StreamReader sr = new StreamReader("c:\\temp\\K1\\t1.txt");
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sr = new StreamReader("c:\\temp\\K1\\t2.txt");
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sw.Close();
            File.Move("c:\\temp\\K1\\t2.txt", "c:\\temp\\K2\\t2.txt");
            File.Copy("c:\\temp\\K1\\t1.txt", "c:\\temp\\K2\\t1.txt");
            Directory.Move("c:\\temp\\K2", "c:\\temp\\ALL");
            Directory.Delete("c:\\temp\\K1", true);
            DirectoryInfo dinf = new DirectoryInfo("c:\\temp\\ALL");
            FileInfo[] finf = dinf.GetFiles();
            foreach (FileInfo fi in finf)
            {
                Console.WriteLine(fi.FullName.ToString() + fi.Attributes.ToString());
            }
            Console.ReadLine();
        }
    }
}