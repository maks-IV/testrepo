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
            Car car8 = new Car();
            Car car9 = new Car();
            Car car10 = new Car();
            car.Name = "Audi";
            car10.Name = "MITSUBISSI";
            Console.WriteLine("Hello World!!");
        }

        static void NewCarMethodUpdated()
        {
            Console.WriteLine("New method!");
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
