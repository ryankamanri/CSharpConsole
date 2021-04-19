using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsole
{
    class NewClass
    {
        public int id;
        public string name;

        /* 有参构造函数*/
        public NewClass(int _id,string _name)
        {
            id = _id;
            name = _name;
        }

        /* 无参构造函数 */
        public NewClass()
        {
            id = 0;
            name = "default";
        }

        public override string ToString()//重写toString方法
        {
            return "id: " + id + ",name: " + name;
        }

        ///
    }
}
