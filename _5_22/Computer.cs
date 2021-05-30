using System;
using System.Collections.Generic;
using System.Text;

namespace _5_22
{
    abstract class Computer
    {
        public IUSB uSB1;

        public Computer() { }
        public abstract void Open();
        public abstract void Close();
    }
}
