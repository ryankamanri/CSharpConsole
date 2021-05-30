using System;
using System.Collections.Generic;
using System.Text;

namespace _5_16
{
    class Dog:Animal
    {
        public bool HasHairs { get; set; } = false;

        public Dog(double weight, double height) : base(weight, height)
        {

        }

        public override void Call()
        {
            Console.WriteLine("Wow");
        }
    }
}
