using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MarkdownApplication
{
    class Replacer
    {
	    public string replace(string input, string wordToFind, string replacement) {
            string pattern = String.Format(@"\b{0}\b", wordToFind);
            return Regex.Replace(input, pattern, replacement);
	    }
    }
}