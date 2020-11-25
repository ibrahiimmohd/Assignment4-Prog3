using System;
using System.Text;

namespace Question2A
{
    public static class Extension
    {
        public static int WordCount(this StringBuilder stringBuilder)
        {

            return stringBuilder.ToString().Split(" ").Length;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new StringBuilder("This is to test whether the extension method count can return a right answer or not").WordCount());
        }

    }
}
