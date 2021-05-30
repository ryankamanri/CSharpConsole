using System;
using System.Collections.Generic;
using System.Text;

namespace _5_16
{
    abstract class Animal
    {
        public double Weight { get; private set; }//只能在类当中被修改
        public double Height { get; private set; }

        public Animal(double weight,double height)
        {
            Weight = weight;
            Height = height;
        }

        public void Move()
        {
            Console.WriteLine("Can Move");
        }

        public void Sleep()
        {
            Console.WriteLine("Can Sleep");
        }

        public abstract void Call();
        //public override string ToString()
        //{
        //    return "Weight : " + Weight + "\nHeight : " + Height;
        //}
    }
}
