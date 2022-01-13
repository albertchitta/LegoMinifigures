using LegoMinifigures.Legos;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Minifigure cowboy = new Minifigure
            {
                HairHat = "Cowboy Hat",
                Head = "Big",
                Torso = "Brown Vest",
                Legs = "Cowboy Pants",
                Accessories = "Lasso",
            };

            Minifigure worker = new Minifigure
            {
                HairHat = "Curly Hair",
                Head = "Glasses",
                Torso = "Jacket",
                Legs = "Dress Pants",
                Accessories = "Briefcase",
            };

            cowboy.Attack();
            worker.DoubleJump();
        }
    }
}
