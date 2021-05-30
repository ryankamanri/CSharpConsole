using System;
using System.Collections.Generic;
using System.Text;

namespace _5_22
{
    class AbstractChild : AbstractParent,IParent
    {
        public override void AbstractFunction()
        {
            Console.WriteLine("我是抽象子类里的重写方法,被我重写的父类同名方法没有方法体");
        }

        public void IFunction()
        {
            Console.WriteLine("我是抽象子类中对接口方法的实现");
        }
    }
}
