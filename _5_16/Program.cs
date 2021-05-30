using System;

namespace _5_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal dog = new Dog(3, 50);
            Animal cat = new Cat(2, 40);

            Console.WriteLine(dog.ToString());
            //Console.WriteLine(dog.HasHairs);
            dog.Move();
            dog.Sleep();
            dog.Call();
            cat.Call();
            
            


            //    //            里氏转换原则
            //    //1子类对象可以直接斌值给父类变量；
            //    //2子类对象可以调用父类中的成员，但是父类对象永远只能调用自己的成员；
            //    //如果父类变量中装的是子类对象，可以将这个父类对象强转为子类对象；

            //    //Animal animal = new Cat(6, 50);
            //    //animal.Move();
            //    //animal.Sleep();
            //    //Console.WriteLine(animal.ToString());
            //    //Cat cat1 = (Cat)animal;
            //    //Console.WriteLine(cat1.HasHairs);
            //    //Console.WriteLine(cat1.ToString());

            //    //Cat Dog 没有继承的话
            //    //所有的类会默认继承的类 

            //    Object obj = new Cat(6, 60);
            //    Console.WriteLine(obj.ToString());

            //    Cat cat2 = (Cat)obj;
            //    cat2.Sleep();


            //    //            装箱和拆箱(堆栈关系操作)
            //    //装箱：值类型ー一 > 引用类型
            //    //拆箱：引用类型ー一 > (显式的强制转换)值类型
            //    //两种类型只有存在继承关系的时候，才可能出现装箱或拆箱操作。



            //}


            //Number<int> intSwap = new Number<int>();
            //Number<char> charSwap = new Number<char>();
            //int i1 = 1, i2 = 2;
            //char a = 'a', b = 'b';
            //Console.WriteLine($"i1 = {i1}, i2 = {i2}");
            //Console.WriteLine($"a = {a},b = {b}");
            //intSwap.Swap(ref i1,ref i2);
            //charSwap.Swap(ref a,ref b);
            //Console.WriteLine("after swapped");
            //Console.WriteLine($"i1 = {i1}, i2 = {i2}");
            //Console.WriteLine($"a = {a},b = {b}");
        }
    }
}
