using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_Ковариантность_и_контрвариантность
{
    interface IInterface<out T> where T : A
    {
        T GetT(); // ковариантный интерфейс
        //T Prop { get; }
    }
    interface IInterface2<in T> where T : A
    {
        void SetT(T t); // контр вариантный интерфейс
        //T Prop { set; }
    }

    interface IQ
    {
        int Prop { get; }
    }

    class MyQ : IQ
    {
        int y;

        public int Prop
        {
            get { return y; }
            set { y = value; }
        }
    }
    class MyClass : IInterface<B>
    {
        public B GetT()
        {
            return new B();
        }
    }
    class MyClass2 : IInterface2<A>
    {
        public void SetT(A t)
        {
            t.Method();
        }
    }
    class MyClass3 : IInterface2<B>
    {
        public void SetT(B t)
        {
            t.Method();
        }
    }

    class A
    {
        public virtual void Method()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public override void Method()
        {
            Console.WriteLine("B");
        }
    }

    delegate A MyDelegate();

    delegate void MyDelegate2(B b);

    class Program
    {
        static void Main(string[] args)
        {
            IInterface<B> interB = new MyClass();
            IInterface<A> interA = interB;
            interA.GetT();

            IInterface2<B> inter2B = new MyClass2();
            inter2B.SetT(new B());


            MyDelegate myDelegate = () => new A();
            myDelegate = () => new B();  // Ковариантность

            MyDelegate2 myDelegate2 = M1;
            myDelegate2(new B());

            myDelegate2 = M2;
            myDelegate2(new B());

            Console.ReadKey();
        }

        static void M1(B b)
        {
            b.Method();
        }

        static void M2(A a)
        {
            a.Method();
        }
    }
}
