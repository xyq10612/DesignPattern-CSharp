using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSample
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public abstract void display();
        public void performFly() => flyBehavior.fly();
        public void performQuack() => quackBehavior.quack();

        public void swin()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
