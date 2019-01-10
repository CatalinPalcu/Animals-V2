using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Piranha : Animal, ISwiming
    {
        private static readonly Categories category;

        private double maxSwimingSpeed = 0;
        private int length = 1;


        public double MaxSwimingSpeed { get => this.maxSwimingSpeed; set => this.maxSwimingSpeed = (value >= 0) ? value : maxSwimingSpeed; }
        public int Length { get => this.length; set => this.length = (value > 0) ? value : length; }

        static Piranha()
        {
            category = Categories.Fish;
        }

        public Piranha() { }

        public Piranha(string _name, double _maxSwimingSpeed, int _length) : base(_name)
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
}
