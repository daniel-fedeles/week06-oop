using System;

namespace IComparableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "bvsahd";
            string y = "avcfdr";
            Console.WriteLine(String.Compare(x, x, StringComparison.Ordinal));
        }
    }
}
