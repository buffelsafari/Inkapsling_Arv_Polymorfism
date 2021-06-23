using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo
{
    class Worm : Animal
    {
        private double elasticity;

        public double Elasticity
        {
            get => elasticity;
            set
            {
                elasticity = value;
            }
        }

        public Worm(string name, int ownerId, double weight, double length, double elasticity) : base(name, ownerId, weight, length)
        {
            this.elasticity = elasticity;
        }

        public override void DoSound()
        {
            string[] str = this.GetType().ToString().Split('.');
            Console.WriteLine($"The {str[str.Length - 1]} named {this.Name} says a slimy line.");            
        }

        public override string Stats()
        {
            return base.Stats() + $"\telasticity:{this.elasticity}";
        }
    }
}
