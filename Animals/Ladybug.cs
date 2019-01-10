using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Ladybug : Animal, IWalking, IFlying
    {
        public enum LadybugColor
        {
            Red,
            Yellow,
            Black
        }

        private static readonly Categories category;

        private double maxWalkingSpeed = 0;
        private double maxFlyingSpeed = 0;

        private readonly int numberOfPoints;
        private readonly LadybugColor color;

        public double MaxWalkingSpeed { get => this.maxWalkingSpeed; set => this.maxWalkingSpeed = (value >= 0) ? value : maxWalkingSpeed; }
        public double MaxFlyingSpeed { get => this.maxFlyingSpeed; set => this.maxFlyingSpeed = (value >= 0) ? value : maxFlyingSpeed; }

        static Ladybug()
        {
            category = Categories.Insect;
        }

        public Ladybug()
        {
            color = LadybugColor.Red;
            numberOfPoints = 6;
        }

        public Ladybug(string _name, double _maxWalkingSpeed, double _maxFlyingSpeed, LadybugColor _color, int _numberOfPoints) : base(_name)
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
