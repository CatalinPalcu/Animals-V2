using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public enum Categories
    {
        Mammal,
        Fish,
        Bird,
        Reptile,
        Insect
    }

    public enum Color
    {
        Red,
        Yellow,
        Black
    }

    public class Animal
    {
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

}
