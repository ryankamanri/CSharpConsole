using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5
{
    class Class1
    {
        //字段
        public int publicData;
        private int privateData;


        protected int protectedData; 

        public int GetPrivateData()
        {
            return privateData;
        }
        public void SetPrivateData(int value)
        {
            if (value < 0) value = 0;
            privateData = value;
        }


        //手动属性 属性 = 字段 + 访问方法

        public int PrivateData
        {
            get
            {
                return privateData;
            }
            set
            {
                if (value < 0) value = 0;
                privateData = value;
            }
        }

        //自动属性
        public int Data { get; private set; }

        public readonly int data;
    }
}
