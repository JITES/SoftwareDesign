using System.Collections.Generic;
using System;
namespace designPattern.creational.AbstractFactoryMethod
{

    class MyClass
    {
        static void DMain()
        {
            IClothsFactory zaraF = new Zara();
            StoreClient zaraClient = new StoreClient(zaraF, "Luxary");
            Console.WriteLine("Zara Factory");
            Console.WriteLine(zaraClient.GetJeanType() );
            Console.WriteLine(zaraClient.GetShirtType());

            zaraClient = new StoreClient(zaraF, "Latest");
            Console.WriteLine(zaraClient.GetJeanType());
            Console.WriteLine(zaraClient.GetShirtType());


            IClothsFactory leeF = new Lee();
            Console.WriteLine("Lee Factory");

            StoreClient leeClient = new StoreClient(leeF, "Luxary");
            Console.WriteLine(leeClient.GetJeanType());
            Console.WriteLine(leeClient.GetShirtType());

            leeClient = new StoreClient(leeF, "Latest");
            Console.WriteLine(leeClient.GetShirtType());
            Console.WriteLine(leeClient.GetShirtType());


            Console.ReadKey();
        }

    }

    class StoreClient
    {
        IJeans jeans;
        IShirt shirt;

        public StoreClient(IClothsFactory clothsFactory, string type)
        {
            jeans = clothsFactory.GetJeans(type);
            shirt = clothsFactory.GetShirt(type);
        }

        public string GetShirtType()
        {
            return shirt.Shirt();
        }

        public string GetJeanType()
        {
            return jeans.Jeans();
        }
    }

    /// <summary>
    /// Abstract Factory
    /// </summary>
    interface IClothsFactory
    {
        IJeans GetJeans(string jeansType);
        IShirt GetShirt(string shirtType);
    }


    /// <summary>
    /// Concerete Factory A
    /// </summary>
    class Zara : IClothsFactory
    {
        public IJeans GetJeans(string jeansType)
        {
            switch (jeansType)
            {
                case "Luxary":
                    return new LuxaryJeans();
                case "Latest":
                    return new LatestJeans();
                default:
                    throw new KeyNotFoundException();
            }
        }

        public IShirt GetShirt(string shirtType)
        {
            switch (shirtType)
            {
                case "Luxary":
                    return new LuxaryShirt();
                case "Latest":
                    return new LatestShirt();
                default:
                    throw new KeyNotFoundException();
            }
        }
    }

    /// <summary>
    /// Concerete Factory B
    /// </summary>
    class Lee : IClothsFactory
    {
        public IJeans GetJeans(string jeansType)
        {
            switch (jeansType)
            {
                case "Luxary":
                    return new LuxaryJeans();
                case "Latest":
                    return new LatestJeans();
                default:
                    throw new KeyNotFoundException();
            }
        }

        public IShirt GetShirt(string shirtType)
        {
            switch (shirtType)
            {
                case "Luxary":
                    return new LuxaryShirt();
                case "Latest":
                    return new LatestShirt();
                default:
                    throw new KeyNotFoundException();
            }
        }
    }

    /// <summary>
    /// Abstract Product A
    /// </summary>
    public interface IShirt
    {
        string Shirt();
    }
    /// <summary>
    /// Abstract Product B
    /// </summary>
    public interface IJeans
    {
        string Jeans();
    }

    /// <summary>
    /// Product B1
    /// </summary>
    internal class LatestJeans : IJeans
    {
        public string Jeans()
        {
            return "This is a latest Jeans";
        }
    }

    /// <summary>
    /// Product B2
    /// </summary>
    internal class LuxaryJeans : IJeans
    {
        public string Jeans()
        {
            return "This is a LuxaryJeans";
        }
    }

    /// <summary>
    /// Product A1
    /// </summary>
    internal class LatestShirt : IShirt
    {
        public string Shirt()
        {
            return "This is a latest Shirt";
        }
    }

    /// <summary>
    /// Product A2
    /// </summary>
    internal class LuxaryShirt : IShirt
    {
        public string Shirt()
        {
            return "This is a LuxaryShirt";
        }
    }


    internal class BeachShirt : IShirt
    {
        public string Shirt()
        {
            return "This is a Beach Shirt";
        }
    }

    internal class TrendyShirt : IShirt
    {
        public string Shirt()
        {
            return "This is a Trendy Shirt";
        }
    }

    internal class FunkyJeans : IJeans
    {
        public string Jeans()
        {
            return "This is a Funcky Jeans";
        }
    }

    internal class TrendyJeans : IJeans
    {
        public string Jeans()
        {
            return "This is a Trendy Jeans";
        }
    }

}
