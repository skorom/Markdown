using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarkdownApplication
{
    class szöveg_kétféleképpen
    {
        static void Main(string[] args)
        {
            string x = "almaszósz"; //megjelenítendő adat
            //1. mód:
            Console.WriteLine(x);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(x);
            //2. mód:
            StreamWriter sw = new StreamWriter("pancake.txt");
            sw.Write(x);
            sw.Close();
            Console.ReadKey();
        }
    }
}
