using System;
using System.Collections.Generic;
using System.Text;

namespace _5_22
{
    class Udisk : IUSB
    {
        private string memory;
        public string Producer { get; } = "kingstom";
        public string Read()
        {
            return memory;
        }

        public void Write(string str)
        {
            memory = str;
        }

        public override string ToString()
        {
            return "UDisk" + Producer; 
        }
    }
}
