using System;
using System.Collections.Generic;
using System.Text;

namespace _5_22
{
    abstract class AbstractParent
    {
        public void GeneralFunction()
        {
            Console.WriteLine("我是抽象父类里的普通方法");
        }

        public abstract void AbstractFunction();

    }
}
