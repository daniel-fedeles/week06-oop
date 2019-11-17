using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("gigi", null);
            Console.WriteLine(p.ToString());

            Person x = new Person("kent", 36);
            Console.WriteLine(x.ToString());
        }
    }
}
