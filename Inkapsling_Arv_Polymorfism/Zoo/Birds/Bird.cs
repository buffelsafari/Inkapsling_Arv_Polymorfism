using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo.Birds
{
    class Bird : Animal
    {
        private double cargoWeight;

        public double CargoWeight
        {
            get => cargoWeight;
            set
            {
                cargoWeight = value;
            }
        }

        public Bird(string name, int ownerId, double weight, double length, double cargoWeight):base(name, ownerId, weight, length)
        {
            this.cargoWeight = cargoWeight;       
        }
        public override void DoSound()
        {
            string[] str = this.GetType().ToString().Split('.');
            Console.WriteLine($"The {str[str.Length - 1]} named {this.Name} says beep beep.");            
        }

        public override string Stats()
        {
            return base.Stats() + $"\tcargoWeight:{this.cargoWeight}";            
        }
    }
}
