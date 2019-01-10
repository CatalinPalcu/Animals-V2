using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class WildDuck : Animal, ISwiming, IFlying, IWalking
    {
        private static readonly Categories category;

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
            category = Categories.Bird;
        }

        public WildDuck() { }

        public WildDuck(string _name, double _maxSwimingSpeed, double _maxWalkingSpeed, double _maxFlyingSpeed, int _weight = 20) : base(_name)
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

        public void LoseWeight(int lose)
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
}
