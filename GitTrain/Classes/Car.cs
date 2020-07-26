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
        public string Name { get; set; }
        public int Id { get; set; }

        public void Do()
        {
            Console.WriteLine("Do!");
        }
    }
}
