using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Legos
{
    class Minifigure
    {
        public string HairHat { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public void Jump()
        {
            Console.WriteLine("Jump!");
        }

        public void DoubleJump()
        {
            Console.WriteLine("Double Jump!");
        }

        public void Attack()
        {
            Console.WriteLine("Attack!");
        }

        public void SpecialAttack()
        {
            Console.WriteLine("Special Attack!");
        }
    }
}
