using System;
using System.Collections.Generic;
using System.Text;


/*
 * Define an interface for creating an object, 
 * but let the sub classes decide which class to instantiate. 
 * The Factory method lets a class defer instantiation to subclasses" (c) GoF
 */
namespace designPattern.creational.FactoryMethod2
{
    public interface IReader
    {
        void Read();
    }

    class GIF : IReader
    {
        public void Read()
        {
            // throw new NotImplementedException();
        }
    }

    class JPEG : IReader
    {
        public void Read()
        {
            throw new NotImplementedException();
        }
    }

    class Factory
    {
        public IReader CreateImageReader(string type)
        {
            switch (type)
            {
                case "GIF":
                    return new GIF();
                case "JPEG":
                    return new JPEG();
                default:
                    throw new Exception();
            }
        }
    }
}


namespace designPattern.creational.FactoryMethod
{
    public interface IProduct
    {
        void Drive(int miles);
    }

    public class Scooter : IProduct
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }

    public class Bike : IProduct
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }

    public abstract class VehicalFactory
    {
        public abstract IProduct GetVehical(string vehical);
    }

    public class ConcreteVehicalFactory : VehicalFactory
    {
        public override IProduct GetVehical(string vehical)
        {
            switch (vehical)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException("Vehical can`t be created");
            }
        }
    }

    public class Factory
    {
       public void Implementation()
        {
            VehicalFactory factory = new ConcreteVehicalFactory();
            IProduct scooter = factory.GetVehical("Scooter");
            scooter.Drive(10);

            IProduct bike = factory.GetVehical("Bike");
            bike.Drive(20);
        }
    }
}
namespace designPattern.creational.FactoryMethod2
{
    public interface IShape
    {
        void Draw();
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }

    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Triangle");
        }
    }

    public class ShapeConcereteFactory
    {
        public static IShape GetShape(string type)
        {
            switch (type)
            {
                case "Rectangle":
                return new Rectangle();
                case "Square":
                    return new Square();
                case "Triangle":
                    return new Triangle();
                default:
                    throw new ApplicationException("t");
            }

        }
    }
}