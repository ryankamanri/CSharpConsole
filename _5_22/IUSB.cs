using System;
using System.Collections.Generic;
using System.Text;

namespace _5_22
{
    interface IUSB
    {
        string Read();
        void Write(string str);
    }
}
