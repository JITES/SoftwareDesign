using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.behavioral.Decorator
{
    public abstract class Beverage
    {
       public string description;

        public string GetDescription()
        {
            return description;
        }
        public abstract double Cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        public abstract new string GetDescription();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = this.GetType().Name;
        }
        public override double Cost()
        {
            return .89;
        }
    }

    public class Mocha : CondimentDecorator
    {
        readonly Beverage _beverage;

        public Mocha(Beverage beverage) => this._beverage = beverage;

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }
        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }
    }

    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = this.GetType().Name;
        }
        public override double Cost()
        {
            return 1.99;
        }
    }

    public class Implements
    {
        public void Main()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
        }

    }
}
