using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1A
{
    class Program
    {
        //static int Search(string[] arrayToSearch, string searchKey)
        //{
        //    int iteration = 0;
        //    foreach (string search in arrayToSearch)
        //    {
        //        if (searchKey == search)
        //            return iteration;
        //        iteration++;
        //    }
        //    return -1;
        //}
        static int Search<T>(T[] arrayToSearch, T searchKey)
        {
            return Array.IndexOf(arrayToSearch, searchKey);
        }
        static void Main(string[] args)
        {
            string[] wordList = { "okay", "yes", "maybe", "but", "no" };
            Console.WriteLine("location of 'no' in wordlist is " + Search(wordList, "no"));
            Console.WriteLine("when location is not found in word list it is " + Search(wordList, "ayaya"));

            double[] wordList2 = { 1.2, 2.3, 3.4, 4.5, 6 };
            Console.WriteLine("location of 'no' in wordlist is " + Search(wordList2, 1.2));
            Console.WriteLine("when location is not found in word list it is " + Search(wordList2, 12));


            Console.ReadKey();
        }
    }
}
