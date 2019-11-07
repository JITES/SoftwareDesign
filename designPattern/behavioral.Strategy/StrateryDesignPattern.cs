using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.behavioral.Strategy
{
    // Extract the behaviours which various and implement it using Interfaces

    // Program to Interface
    // Animal animal = new Dog();
    // animal.MakeSound();

    interface IFlyBehaviour
    {
        void Fly();
    }

    interface IQuackBehaviour
    {
        void Quack();
    }

    class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine(this.GetType().Name);

        }
    }

    class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }

    class Quack : IQuackBehaviour
    {
        // implement duck quacking
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }

    class Squeak : IQuackBehaviour
    {
        // rubber duckie squeak
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }

    class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }

    class Duck
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;

        public void SetFlyingBehaviour(IFlyBehaviour fly)
        {
            this.flyBehaviour = fly;
        }

        public void SetQuackBehaviour(IQuackBehaviour quack)
        {
            this.quackBehaviour = quack;
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
        }

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }
    }

    class StrategyDesignPattern : Duck
    {
        public StrategyDesignPattern()
        {
            this.quackBehaviour = new Squeak();
            this.flyBehaviour = new FlyWithWings();
        }

        public static void Main()
        {
            StrategyDesignPattern strategy = new StrategyDesignPattern();
            strategy.PerformFly();

            // Ability to change the behaviour on run time
            strategy.SetFlyingBehaviour(new FlyNoWay()); // It can be = new FlyWithWings();
            strategy.PerformFly();
            strategy.PerformQuack();

            strategy.SetQuackBehaviour(new Squeak());
            strategy.PerformQuack();
        }
    }

    class MalardDuck : Duck
    {
        IFlyBehaviour flyBehave;
        IQuackBehaviour quakBehaviour;
        public MalardDuck()
        {
            flyBehave = new FlyWithWings();
            quackBehaviour = new MuteQuack();
        }
    }

}
