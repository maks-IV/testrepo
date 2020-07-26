using System;
using System.Collections.Generic;
using System.Text;

namespace GitTrain.Classes
{
    public class Car
    {
        public Car()
        {

        }
        public int Name { get; set; }
        public int CarId { get; set; }

        public void Do()
        {
            Console.WriteLine("Do!");
            Console.WriteLine("Done!");
        }
    }
}
