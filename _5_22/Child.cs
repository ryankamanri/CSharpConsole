using System;
using System.Collections.Generic;
using System.Text;

namespace _5_22
{
    class Child : Parent,IParent
    {

        public override void VirtualFunction()
        {
            //base.VirtualFunction(); //调用父类方法
            Console.WriteLine("我是普通子类里的重写方法,父类里的方法已经被我覆盖");
        }


        public void IFunction()
        {
            Console.WriteLine("我是普通子类中对接口方法的实现");
        }
    }
}
