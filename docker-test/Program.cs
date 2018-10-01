using System;
using docker_test.dependency;

namespace docker_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var x = new Class1();
            x.world();
            Console.ReadLine();
        }
    }
}
