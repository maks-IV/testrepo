using GitTrain.Classes;
using System;

namespace GitTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World 2!");
        }

        static void NewCarMethod()
        {
            Console.WriteLine("New method!");
        }
    }
}
