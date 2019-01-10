using System;
using System.Text;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Platypus ornitorinc = new Platypus("Ornitorinc", 20, 4,2);
            WildDuck rata = new WildDuck("Donald", 20, 6, 35, 500);
            Piranha piranha = new Piranha("Nemo", 25, 250);
            AhkistrodonPiscivorus mocasin = new AhkistrodonPiscivorus("Boa", 20, 15, "frogs");
            Ladybug gargarita = new Ladybug("Gargarita", 0.5, 15, Ladybug.LadybugColor.Black, 12);

            Animal[] animals = { ornitorinc, rata, piranha, mocasin, gargarita };
            Console.WriteLine("\t\tInitialy\n");
            foreach(Animal a in animals)
                Console.WriteLine($"{a}\n");

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            ornitorinc.MakeAnEgg();
            ornitorinc.MakeAnEgg();
            ornitorinc.BreakAnEgg();
            ornitorinc.Hatch();

            rata.GainWeight(45);
            piranha.Grow(10);
            mocasin.AddFavouriteFood(" trout triton");
            mocasin.RemoveFavouriteFood("frogs");
            
            Console.WriteLine("\t\tAfter the changes\n");
            foreach (Animal a in animals)
                Console.WriteLine($"{a}\n");
        }
    }
}
