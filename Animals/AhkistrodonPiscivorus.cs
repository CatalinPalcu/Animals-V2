using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class AhkistrodonPiscivorus : Animal, ICrawling, ISwiming  //Mocasinul-de-apa
    {
        private static readonly Categories category;

        private double maxSwimingSpeed = 0;
        private double maxCrawlingSpeed = 0;
        private StringBuilder favouriteFood = new StringBuilder();

        public double MaxSwimingSpeed { get => this.maxSwimingSpeed; set => this.maxSwimingSpeed = (value >= 0) ? value : maxSwimingSpeed; }
        public double MaxCrawlingSpeed { get => this.maxCrawlingSpeed; set => this.maxCrawlingSpeed = (value >= 0) ? value : maxCrawlingSpeed; }
        public string FavouriteFood { get => this.favouriteFood.ToString(); }
        static AhkistrodonPiscivorus()
        {
            category = Categories.Reptile;
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
}
