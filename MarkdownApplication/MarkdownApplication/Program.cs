using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace MarkdownApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Replacer r = new Replacer();
            Console.WriteLine(r.replace("mfgfdgmsfk nyuszi hms ### kghshnyusziisgihathaonyuszijhiahjiaerhu", "nyuszi", "minden kecske okos"));
            Console.ReadKey();
            Read(Console.ReadLine());
        }
        public static void Read(string filepath)
        {
            string file = File.ReadAllText(filepath);
            List<Text> Text = JsonConvert.DeserializeObject<Text>(file);
        }
    }
}
