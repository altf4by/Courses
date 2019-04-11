using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Ducks
{
    abstract class Duck
    {
        protected IFlyable flyBehavior;
        protected IQryakable qryakBehavior;

        public Duck()
        {
            flyBehavior = new SimpleFly();
            qryakBehavior = new SimpleQryak();
        }

        protected Duck(IFlyable flyBehavior, IQryakable qryakBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.qryakBehavior = qryakBehavior;
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming.");
        }
        public void Qryak()
        {
            qryakBehavior.Qryak();
        }

        public void Fly()
        {
            flyBehavior.Fly();
        }
        public void ChangeFlyBehavoir()
        {
            if (flyBehavior is NoFly)
                flyBehavior = new SimpleFly();
            else flyBehavior = new NoFly();
        }

        public abstract void Display();


    }
}
