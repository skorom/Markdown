using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Replacer r = new Replacer();
            Console.WriteLine(r.replace("mfgfdgmsfk nyuszi hms ### kghshnyusziisgihathaonyuszijhiahjiaerhu", "nyuszi", "minden kecske okos"));
            Console.ReadKey();
        }
    }
}
