using System;
using System.Collections.Generic;
using System.Text;

namespace _5_16
{




    public class Number<Type>
    {
        public void Swap(ref Type a1, ref Type a2)
        {
            Type temp;
            temp = a1;
            a1 = a2;
            a2 = temp;
        }
    }

}
