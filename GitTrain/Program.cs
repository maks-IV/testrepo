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
            Car car3 = new Car();
            Car car4 = new Car();
            car.Name = "Audi";
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World 2!");
        }

        static void NewCarMethod()
        {
            Console.WriteLine("New method!");
            Console.WriteLine("HELLOW");
        }

        //static void Method2()
        //{
        //    Console.WriteLine("New Method2!");
        //}

        static void Method3()
        {
            Console.WriteLine("Method 3!");
        }
    }
}
