using System;
using System.Collections.Generic;
using System.Text;

namespace _5_16
{
    class Cat : Animal
    {
        public bool HasHairs { get; set; } = true;

        public Cat(double weight,double height):base(weight,height)
        {

        }

        public void Call()
        {
            Console.WriteLine("Mew");
        }
    }
}
