using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Deals2Buy
{
    class StringExtensions
    {
        public static string Cleanup(string str)
        {
            if (str == null)
                return string.Empty;
            str = str.Trim();
            Regex html = new Regex("<([^>]+)>");
            Regex multiple_spaces = new Regex("(" + Regex.Escape(" ") + "{2,}" + ")");
            Regex multiple_newline = new Regex(Regex.Escape("\n") + "{2,}");
            str = html.Replace(str, " ");
            str = multiple_newline.Replace(str, "");
            str = multiple_spaces.Replace(str, " ");
            
            return str;
        }
    }
}
