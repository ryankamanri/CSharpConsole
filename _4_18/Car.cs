using System;
using System.Collections.Generic;
using System.Text;

namespace _4_18
{
    class Car
    {
        public double weight;
        public string brand;
        DateTime date;
        public double maxSpeed;
        public readonly static string Token = "Can not read";
        public Car()
        {

        }

        public Car(double weight,string brand,DateTime date,double maxSpeed)
        {
            this.weight = weight;
            this.brand = brand;
            this.date = date;
            this.maxSpeed = maxSpeed;

        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }

        public bool CompareWeight(Car c2)
        {
            if (this.weight >= c2.weight) return true;
            else if (this.weight < c2.weight) return false;
            else return true;
        }
        
        public override string ToString()
        {
            return "weight: " + weight + "\nbrand:" + brand + "\ndate:" + date + "\nmaxSpeed:" + maxSpeed;
        }
    }
}
