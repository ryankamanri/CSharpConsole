using System;
using System.Collections.Generic;
using System.Text;

namespace _5_22
{
    class PC : Computer
    {

        private static bool IsInstanced { get; set; } = false;
        private int Num { get; set; }
        public PC(int num)
        {
            Num = num;
        }

        //这台电脑的单实例设计构造函数,只能被实例化一次
        public static PC PCConstructor(int num)
        {
            if (IsInstanced == true) return null;
            IsInstanced = true;
            return new PC(num);
        }
        public override void Close()
        {
            Console.WriteLine("关机");
        }

        public override void Open()
        {
            Console.WriteLine("开机");
        }

        public void InsertUdisk(IUSB uSB)
        {
            base.uSB1 = uSB;
        }

        public void PrintNum()
        {
            Console.WriteLine(Num);
        }

        public void WriteToUSB(string str)
        {
            base.uSB1.Write(str);
        }

        public string ReadFromUSB()
        {
            return base.uSB1.Read();
        }
    }
}
