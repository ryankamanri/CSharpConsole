using System;
using System.Collections.Generic;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car c1 = new Car();
            //Console.WriteLine("c1 : \n");
            //c1.Display();

            //int a = 100;
            //int b = a;
            //Console.WriteLine(b);
            //b++;
            //Console.WriteLine(b);
            //Console.WriteLine(a);




            Car c2 = new Car(1000, "Benz", new DateTime(2021, 4, 18), 240);
            Console.WriteLine("c2 : \n");
            c2.Display();

            //Car c3 = c2;
            //c3.brand = "Bicycle";
            //Console.WriteLine("c3: \n");
            //c3.Display();

            //Console.WriteLine(  "c2: \n");
            //c2.Display();

            //Console.WriteLine(Car.Token);

            //StaticClassTest.Output();
            //Console.WriteLine($"{ StaticClassTest.ID},{StaticClassTest.ID_2},{StaticClassTest.location}");

            string str  =   ConsoleIO.Scan();

            ConsoleIO.Print(str);//打印string

            ConsoleIO.Print(c2);//打印Car
        }
    }

}
