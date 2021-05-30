
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpConsole
{
    class AsyncWaitTest
    {
        public static async Task ThrowRubbish(string who)
        {
            Console.WriteLine(who + " : 好的" + "线程 : " + Thread.CurrentThread);
            Thread.Sleep(1000);
            Console.WriteLine(who + " : 我扔完了" + "线程 : " + Thread.CurrentThread);


        }
        static void Main()
        {
            //我躺在沙发上看电视,妈妈喊我下楼丢垃圾
            //Main为妈妈做的事
            Console.WriteLine("妈妈 : 快去扔垃圾" + "线程 : " + Thread.CurrentThread);
            ThrowRubbish("我");
            Console.WriteLine("妈妈 : 怎么还不回来" + "线程 : " + Thread.CurrentThread);
        }
    }
}
