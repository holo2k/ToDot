using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDot
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFile = File.ReadAllText("1.txt", Encoding.GetEncoding("windows-1251"));
            string secondFile = firstFile.Replace(',', '.');
            File.WriteAllText("2.txt", secondFile);
            Console.WriteLine("------------------------");
            Console.WriteLine("Операция прошла успешно.");
            Console.WriteLine("------------------------");
            Console.ReadKey();
        }
    }
}
