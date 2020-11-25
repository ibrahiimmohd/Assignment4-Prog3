using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1A
{
    class Program
    {
        static int Search(string[] arrayToSearch, string searchKey)
        {
            int iteration = 0;
            foreach (string search in arrayToSearch)
            {
                if (searchKey == search)
                    return iteration;
                iteration++;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            string[] wordList = { "okay", "yes", "maybe", "but", "no" };
            Console.WriteLine("location of 'no' in wordlist is " + Search(wordList, "no"));
            Console.WriteLine("when location is not found in word list it is " + Search(wordList, "ayaya"));
        }
    }
}
