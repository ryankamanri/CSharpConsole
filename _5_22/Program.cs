using System;

namespace _5_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Parent parent = new Parent();
            //parent.VirtualFunction();
            //Child child = new Child();
            //child.VirtualFunction();
            //child.IFunction();
            //AbstractParent abstractParent = new AbstractParent();
            //AbstractChild abstractChild = new AbstractChild();
            //abstractChild.GeneralFunction();
            //abstractChild.AbstractFunction();
            //abstractChild.IFunction();

            PC pc = PC.PCConstructor(1);
            pc.PrintNum();

            PC pc2 = PC.PCConstructor(2);
            pc.PrintNum();

            IUSB uSB = new Udisk();
            pc.InsertUdisk(uSB);

            Console.WriteLine(pc.ReadFromUSB());//电脑第一次从USB里面读数据 null

            pc.WriteToUSB("1223");

            Console.WriteLine(pc.ReadFromUSB()); //1223
        }
    }
}
