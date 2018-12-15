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

    public class Animal 
    {
        protected enum AnimalCategories
        {
            Mammal,
            Fish,
            Bird,
            Reptile,
            Insect
        }

        public string Name { get; set; }

        public Animal()
        {
            Name = "[no name]";
        }

        public Animal(string name)
        {
            Name = name;
        }
    }



    interface IFlying
    {
        double MaxFlyingSpeed { get; set; }
        void Fly();
    }

    interface IWalking
    {
        double MaxWalkingSpeed { get; set; }
        void Walk();
    }

    interface ISwiming
    {
        double MaxSwimingSpeed { get; set; }
        void Swim();
    }

    interface ICrawling
    {
        double MaxCrawlingSpeed { get; set; }
        void Crawl();
    }

    public class Platypus : Animal, ISwiming, IWalking
    {
        private static readonly AnimalCategories category;

        private double maxSwimingSpeed = 0;
        private double maxWalkingSpeed = 0;
        private int numberOfEggs = 0;

        public double MaxSwimingSpeed { get => this.maxSwimingSpeed; set =>this.maxSwimingSpeed= (value >= 0)?value:maxSwimingSpeed; }
        public double MaxWalkingSpeed { get => this.maxWalkingSpeed; set => this.maxWalkingSpeed = (value >= 0) ? value : maxWalkingSpeed; }
        public int NumberOfEggs { get => this.numberOfEggs;private set => this.numberOfEggs = (value >= 0) ? value : numberOfEggs; }

        

        static Platypus()
        {
            category = AnimalCategories.Mammal;
        }

        public Platypus() { }

        public Platypus(string _name, double _maxSwimingSpeed, double _maxWalkingSpeed, int _numberOfEggs):base(_name)
        {
            MaxSwimingSpeed = _maxSwimingSpeed;
            MaxWalkingSpeed = _maxWalkingSpeed;
            NumberOfEggs = _numberOfEggs;
        }

        public void Swim()
        {
            Console.WriteLine($"{this.Name} is swiming around with the maximum speed of {MaxSwimingSpeed}");
        }

        public void Walk()
        {
            Console.WriteLine($"{this.Name} is walking around with the maximum speed of {maxWalkingSpeed}");
        }

        public void MakeAnEgg()
        {
            Console.WriteLine($"{Name} just made another egg");
            NumberOfEggs++;
        }

        public void BreakAnEgg()
        {
            if (numberOfEggs > 0)
            {
                Console.WriteLine($"{Name} wasn't careful and just broke an egg");
                NumberOfEggs--;
            }
        }

        public void Hatch()
        {
            if (numberOfEggs > 0)
                Console.WriteLine($"All {numberOfEggs} eggs of {Name} just have hatched.");
            NumberOfEggs = 0;
        }

        public override string ToString()
        {
            return String.Format($"{Name} is a platypus, belongs to the category {category} now it have {numberOfEggs} eggs and have the following abilities:\n" +
                $"\t- it can swim with the maximum speed of {MaxSwimingSpeed}\n\t- it can walk with the maximum speed of {MaxWalkingSpeed}");
        }
    } // end of class Platypus

    public class WildDuck : Animal, ISwiming, IFlying, IWalking
    {
        private static readonly AnimalCategories category;

        private double maxSwimingSpeed = 0;
        private double maxWalkingSpeed = 0;
        private double maxFlyingSpeed = 0;
        private double weight = 20;

        public double MaxSwimingSpeed { get => this.maxSwimingSpeed; set => this.maxSwimingSpeed = (value >= 0) ? value : maxSwimingSpeed; }
        public double MaxWalkingSpeed { get => this.maxWalkingSpeed; set => this.maxWalkingSpeed = (value >= 0) ? value : maxWalkingSpeed; }
        public double MaxFlyingSpeed { get => this.maxFlyingSpeed; set => this.maxFlyingSpeed = (value >= 0) ? value : maxFlyingSpeed; }
        public double Weight { get => this.weight; private set => this.weight = (value >= 20) ? value : weight; }

        static WildDuck()
        {
            category = AnimalCategories.Bird;
        }

        public WildDuck() { }

        public WildDuck(string _name, double _maxSwimingSpeed, double _maxWalkingSpeed, double _maxFlyingSpeed, int _weight = 20) :base(_name)
        {
            MaxSwimingSpeed = _maxSwimingSpeed;
            MaxWalkingSpeed = _maxWalkingSpeed;
            MaxFlyingSpeed = _maxFlyingSpeed;
            Weight = _weight;
        }

        public void Fly()
        {
            Console.WriteLine($"{this.Name} is flying around with the maximum speed of {MaxFlyingSpeed}");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.Name} is swiming around with the maximum speed of {MaxSwimingSpeed}");
        }

        public void Walk()
        {
            Console.WriteLine($"{this.Name} is walking around with the maximum speed of {maxWalkingSpeed}");
        }

        public void GainWeight(int gain)
        {
            Weight += gain;
        }

        public void LoseWeight (int lose)
        {
            if (Weight < lose + 20)
                Console.WriteLine($"{Name} cannot lose so much weight");
            else
                Weight -= lose;
        }

        public override string ToString()
        {
            return String.Format($"{Name} is a wild duck, belongs to the category {category} , have the weight {Weight} grams and have the following abilities:\n" +
                $"\t- it can swim with the maximum speed of {MaxSwimingSpeed}\n\t- it can walk with the maximum speed of {MaxWalkingSpeed}" +
                $"\n\t- it can fly with the maximum speed of {MaxFlyingSpeed}");
        }
    } // end of class WildDuck

    public class Piranha  : Animal, ISwiming
    {
        private static readonly AnimalCategories category;

        private double maxSwimingSpeed = 0;
        private int length = 1;


        public double MaxSwimingSpeed { get => this.maxSwimingSpeed; set => this.maxSwimingSpeed = (value >= 0) ? value : maxSwimingSpeed; }
        public int Length { get => this.length; set => this.length = (value > 0) ? value : length; }

        static Piranha()
        {
            category = AnimalCategories.Fish;
        }

        public Piranha() { }

        public Piranha(string _name, double _maxSwimingSpeed, int _length) :base(_name)
        {
            MaxSwimingSpeed = _maxSwimingSpeed;
            Length = _length;
        }

        public void Swim()
        {
            Console.WriteLine($"{this.Name} is swiming around with the maximum speed of {MaxSwimingSpeed}");
        }

        public void Grow(int extra)
        {
            Length += extra;
        }

        public override string ToString()
        {
            return String.Format($"{Name} is a pirahna, belongs to the category {category}, have the length {Length} mm and have the following abilities:\n" +
                $"\t- it can swim with the maximum speed of {MaxSwimingSpeed}");
        }
    }  // end of class Pirahna

    public class AhkistrodonPiscivorus : Animal, ICrawling, ISwiming  //Mocasinul-de-apa
    {
        private static readonly AnimalCategories category;

        private double maxSwimingSpeed = 0;
        private double maxCrawlingSpeed = 0;
        private StringBuilder favouriteFood = new StringBuilder();

        public double MaxSwimingSpeed { get => this.maxSwimingSpeed; set => this.maxSwimingSpeed = (value >= 0) ? value : maxSwimingSpeed; }
        public double MaxCrawlingSpeed { get => this.maxCrawlingSpeed; set => this.maxCrawlingSpeed = (value >= 0) ? value : maxCrawlingSpeed; }
        public string FavouriteFood { get => this.favouriteFood.ToString(); }
        static AhkistrodonPiscivorus()
        {
            category = AnimalCategories.Reptile;
        }

        public AhkistrodonPiscivorus() { }

        public AhkistrodonPiscivorus(string _name, double _maxSwimingSpeed, double _maxCrawlingSpeed, string food) : base(_name)
        {
            MaxSwimingSpeed = _maxSwimingSpeed;
            MaxCrawlingSpeed = _maxCrawlingSpeed;
            favouriteFood.Append(food);
        }

        public void AddFavouriteFood(string food)
        {
            favouriteFood.Append(" ");
            favouriteFood.Append(food);
        }

        public void RemoveFavouriteFood(string food)
        {
            int index = favouriteFood.ToString().IndexOf(food);
            if (index >= 0)
                favouriteFood.Remove(index, food.Length);
            else
                Console.WriteLine($"{food} is not on the list");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.Name} is swiming around with the maximum speed of {MaxSwimingSpeed}");
        }

        public void Crawl()
        {
            Console.WriteLine($"{this.Name} is crawl around with the maximum speed of {maxCrawlingSpeed}");
        }

        public override string ToString()
        {
            return String.Format($"{Name} is a ahkistrodon piscivorus (type of snake), belongs to the category {category} and have the following abilities:\n" +
                $"\t- it can swim with the maximum speed of {MaxSwimingSpeed}\n\t- it can crawl with the maximum speed of {MaxCrawlingSpeed}" +
                $"\n\t - the favourite food is: {favouriteFood.ToString()}");
        }
    } // end of class AhkistrodonPiscivorus

    public class Ladybug: Animal,IWalking, IFlying
    {
        public enum LadybugColor
        {
            Red,
            Yellow,
            Black
        }

        private static readonly AnimalCategories category;

        private double maxWalkingSpeed = 0;
        private double maxFlyingSpeed = 0;

        private readonly int numberOfPoints;
        private readonly LadybugColor color;

        public double MaxWalkingSpeed { get => this.maxWalkingSpeed; set => this.maxWalkingSpeed = (value >= 0) ? value : maxWalkingSpeed; }
        public double MaxFlyingSpeed { get => this.maxFlyingSpeed; set => this.maxFlyingSpeed = (value >= 0) ? value : maxFlyingSpeed; }

        static Ladybug()
        {
            category = AnimalCategories.Insect;
        }

        public Ladybug()
        {
            color = LadybugColor.Red;
            numberOfPoints = 6;
        }

        public Ladybug(string _name, double _maxWalkingSpeed, double _maxFlyingSpeed,LadybugColor _color, int _numberOfPoints) : base(_name)
        {
            MaxWalkingSpeed = _maxWalkingSpeed;
            MaxFlyingSpeed = _maxFlyingSpeed;
            this.color = _color;
            this.numberOfPoints = _numberOfPoints;

        }

        public void Fly()
        {
            Console.WriteLine($"{this.Name} is flying around with the maximum speed of {MaxFlyingSpeed}");
        }

        public void Walk()
        {
            Console.WriteLine($"{this.Name} is walking around with the maximum speed of {maxWalkingSpeed}");
        }

        public override string ToString()
        {
            return String.Format($"{Name} is a ladybug, belongs to the category {category}, have de color {color} and {numberOfPoints} points on the back" +
                $" and have the following abilities:\n" +
                $"\t- it can walk with the maximum speed of {MaxWalkingSpeed}\n\t- it can fly with the maximum speed of {MaxFlyingSpeed}");
        }
    }


}
