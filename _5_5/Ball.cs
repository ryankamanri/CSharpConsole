using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5
{
    //父类,表示所有的球
    class Ball
    {
        public double R{ get; private set; }
        protected string ID;

        public Ball(double R)
        {
            this.R = R;
        }
    }
}
