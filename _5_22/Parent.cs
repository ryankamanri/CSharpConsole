using System;
using System.Collections.Generic;
using System.Text;

namespace _5_22
{
    class Parent
    {
        public void GeneralFunction()
        {
            Console.WriteLine("我是普通方法");
        }
        public virtual void VirtualFunction()
        {
            Console.WriteLine("我是虚方法,可以写在普通类中,被子类重写");
        }
    }
}
