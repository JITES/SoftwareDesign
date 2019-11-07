using System;
using System.Collections.Generic;

namespace creational.Prototype2
{
    public abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }

    class Sandwich : SandwichPrototype
    {
        private string Bread;
        private string Meat;
        private string Cheese;
        private string Veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngredientList();
            Console.WriteLine("Cloning sandwich with ingredients: {0}", ingredientList.Remove(ingredientList.LastIndexOf(",")));
            // Shallow copy
            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {
            return "G";
        }
    }

    class SandwichMenu
    {
        private Dictionary<string, SandwichPrototype> _sandwiches = new Dictionary<string, SandwichPrototype>();

        public SandwichPrototype this[string name]
        {
            get { return _sandwiches[name]; }
            set { _sandwiches.Add(name, value); }
        }
    }

    class Program
    {
        static void DMain(string[] args)
        {
            SandwichMenu sandwichMenu = new SandwichMenu();

            // Initialize with default sandwiches
            sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
            sandwichMenu["PB&J"] = new Sandwich("White", "", "", "Peanut Butter, Jelly");
            sandwichMenu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");

            // Deli manager adds custom sandwiches
            sandwichMenu["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Tomato, Onion, Olives");
            sandwichMenu["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion");
            sandwichMenu["Vegetarian"] = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tomato, Olives, Spinach");

            // Now we can clone these sandwiches
            Sandwich sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
            Sandwich sandwich2 = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;
            Sandwich sandwich3 = sandwichMenu["Vegetarian"].Clone() as Sandwich;

            // Wait for user
            Console.ReadKey();
        }
    }

}


namespace creational.Prototype
{
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    public class Person
    {
        public int Age;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = (Person)this.MemberwiseClone();
            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            other.Name = String.Copy(Name);
            return other;
        }
    }

    public class Example
    {
        public static void DMain()
        {
            // Create an instance of Person and assign values to its fields.
            Person p1 = new Person();
            p1.Age = 42;
            p1.Name = "Sam";
            p1.IdInfo = new IdInfo(6565);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();

            // Display values of p1, p2
            Console.WriteLine("Original values of p1 and p2:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Change the value of p1 properties and display the values of p1 and p2.
            p1.Age = 32;
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();
            // Change the members of the p1 class to new values to show the deep copy.
            p1.Name = "George";
            p1.Age = 39;
            p1.IdInfo.IdNumber = 8641;
            Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
            Console.WriteLine("      Value: {0:d}", p.IdInfo.IdNumber);
        }
    }
    // The example displays the following output:
    //       Original values of p1 and p2:
    //          p1 instance values:
    //             Name: Sam, Age: 42
    //             Value: 6565
    //          p2 instance values:
    //             Name: Sam, Age: 42
    //             Value: 6565
    //       
    //       Values of p1 and p2 after changes to p1:
    //          p1 instance values:
    //             Name: Frank, Age: 32
    //             Value: 7878
    //          p2 instance values:
    //             Name: Sam, Age: 42
    //             Value: 7878
    //       
    //       Values of p1 and p3 after changes to p1:
    //          p1 instance values:
    //             Name: George, Age: 39
    //             Value: 8641
    //          p3 instance values:
    //             Name: Frank, Age: 32
    //             Value: 7878
}