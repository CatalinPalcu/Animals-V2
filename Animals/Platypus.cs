using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Platypus : Animal, ISwiming, IWalking
    {
        private static readonly Categories category;

        private double maxSwimingSpeed = 0;
        private double maxWalkingSpeed = 0;
        private int numberOfEggs = 0;

        public double MaxSwimingSpeed { get => this.maxSwimingSpeed; set => this.maxSwimingSpeed = (value >= 0) ? value : maxSwimingSpeed; }
        public double MaxWalkingSpeed { get => this.maxWalkingSpeed; set => this.maxWalkingSpeed = (value >= 0) ? value : maxWalkingSpeed; }
        public int NumberOfEggs { get => this.numberOfEggs; private set => this.numberOfEggs = (value >= 0) ? value : numberOfEggs; }



        static Platypus()
        {
            category = Categories.Mammal;
        }

        public Platypus() { }

        public Platypus(string _name, double _maxSwimingSpeed, double _maxWalkingSpeed, int _numberOfEggs) : base(_name)
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
}
