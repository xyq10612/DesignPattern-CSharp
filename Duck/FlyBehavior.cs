﻿using System;

namespace DuckSample
{
    public interface FlyBehavior
    {
        void fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
