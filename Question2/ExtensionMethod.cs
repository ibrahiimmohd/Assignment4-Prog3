using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public static class ExtensionMethod
    {
        public static int WordCount(this StringBuilder sentence)
        {
            return sentence.ToString().Split(' ').Length;
        }
    }
}
