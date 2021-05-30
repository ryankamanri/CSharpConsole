using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        public static  Task ThrowRubbish(string who)
        {

            return new Task(() => {
                Console.WriteLine(who + " : 好的" + "线程 : " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
                Console.WriteLine(who + " : 我扔完了" + "线程 : " + Thread.CurrentThread.ManagedThreadId);
            });

        }

        public static Task<string> ThrowRubbishAndBringAMango(string who)
        {

            return new Task<string>(() => {
                Console.WriteLine(who + " : 好的" + "线程 : " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
                Console.WriteLine(who + " : 我扔完了" + "线程 : " + Thread.CurrentThread.ManagedThreadId);
                return "我带回了一个芒果";
            });

        }
        public static void Main()
        {
            //我躺在沙发上看电视,妈妈喊我下楼丢垃圾
            //Main为妈妈做的事
            Console.WriteLine("妈妈 : 快去扔垃圾" + "线程 : " + Thread.CurrentThread.ManagedThreadId);

            //ThrowRubbish("我").Start();
             var task = ThrowRubbishAndBringAMango("我");
            task.Start();
            Thread.Sleep(500);
            Console.WriteLine("妈妈 : 怎么还不回来" + "线程 : " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("我 : " + task.Result + "线程 : " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("妈妈 : 好的" + "线程 : " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
        }
    }
}
