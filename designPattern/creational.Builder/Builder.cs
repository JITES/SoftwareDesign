using System;

namespace designPattern.creational.Builder
{
    interface IHousePlan
    {
        void SetBasement(string basement);

        void SetStructure(string structure);

        void SetRoof(string roof);

        void SetInterior(string interior);
    }

    /// <summary>
    /// Product
    /// </summary>
    class House : IHousePlan
    {

        private string basement;
        private string structure;
        private string roof;
        private string interior;

        public void SetBasement(String basement)
        {
            this.basement = basement;
        }

        public void SetStructure(String structure)
        {
            this.structure = structure;
        }

        public void SetRoof(String roof)
        {
            this.roof = roof;
        }

        public void SetInterior(String interior)
        {
            this.interior = interior;
        }

    }

    /// <summary>
    /// Builder 
    /// </summary>
    interface IHouseBuilder
    {
        void buildBasement();

        void buildStructure();

        void bulidRoof();

        void buildInterior();

        House getHouse();
    }

    /// <summary>
    /// ConcreteBuilder 
    /// </summary>
    class IglooHouseBuilder : IHouseBuilder
    {
        private House house;

        public IglooHouseBuilder()
        {
            this.house = new House();
        }

        public void buildBasement()
        {
            house.SetBasement("Ice Bars");
        }

        public void buildStructure()
        {
            house.SetStructure("Ice Blocks");
        }

        public void buildInterior()
        {
            house.SetInterior("Ice Carvings");
        }

        public void bulidRoof()
        {
            house.SetRoof("Ice Dome");
        }

        public House getHouse()
        {
            return this.house;
        }
    }

    /// <summary>
    /// ConcreteBuilder 
    /// </summary>
    class TipiHouseBuilder : IHouseBuilder
    {
        private House house;

        public TipiHouseBuilder()
        {
            this.house = new House();
        }

        public void buildBasement()
        {
            house.SetBasement("Wooden Poles");
        }

        public void buildStructure()
        {
            house.SetStructure("Wood and Ice");
        }

        public void buildInterior() => house.SetInterior("Fire Wood");

        public void bulidRoof() => house.SetRoof("Wood, caribou and seal skins");

        public House getHouse()
        {
            return this.house;
        }

    }

    /// <summary>
    /// Director 
    /// </summary>
    class CivilEngineer
    {
        private IHouseBuilder houseBuilder;
        private string v;

        public CivilEngineer(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public CivilEngineer(): this("DLF")
        {
            Console.WriteLine("Welcome to Engineer");
        }

        public CivilEngineer(string v)
        {
            this.v = v;
            Console.WriteLine("DLF Engineers");
        }

        public House GetHouse()
        {
            return this.houseBuilder.getHouse();
        }

        public void ConstructHouse()
        {
            this.houseBuilder.buildBasement();
            this.houseBuilder.buildStructure();
            this.houseBuilder.bulidRoof();
            this.houseBuilder.buildInterior();
        }
    }

    class Builder
    {
        public static void DMain()
        {

            IHouseBuilder igloo = new IglooHouseBuilder();
            CivilEngineer civilEngineer = new CivilEngineer(igloo);
            civilEngineer.ConstructHouse();
            _ = civilEngineer.GetHouse();

        }
    }
}
