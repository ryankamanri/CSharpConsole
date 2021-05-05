using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5
{
    //足球子类,继承Ball父类的所有属性和方法
    class Soccer : Ball
    {
        public double Weight { get; private set; }

        public Soccer(double R, double weight,string ID):base(R)
        {
            
            Weight = weight;
            base.ID = ID;
        }

        /**
         * @param motivate 动量
         * @return 速度
         * */
        public double KickSpeed(double motivate)
        {
            return motivate / Weight;
        }

        /**
         * 返回体积
         * */
        public double GetVolume()
        {
            return 4 * Math.Pow(R, 3) / 3;
        }
        /*
         * 返回密度
         * */
        public double GetDensity()
        {
            return Weight / GetVolume();
        }
    }
}
