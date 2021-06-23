using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo
{
    class Dog : Animal
    {
        private bool isGoodBoy;

        public bool IsGoodBoy
        {
            get => isGoodBoy;
            set
            {
                isGoodBoy = value;
            }
        }
        public Dog(string name, int ownerId, double weight, double length, bool isGoodBoy) : base(name, ownerId, weight, length)
        {
            this.isGoodBoy = isGoodBoy;
        }

        public override void DoSound()
        {
            string[] str = this.GetType().ToString().Split('.');
            Console.WriteLine($"The {str[str.Length-1]} named {this.Name} says woff.");
        }

        public override string Stats()
        {
            return base.Stats() + $"\tgoodBoy={this.IsGoodBoy}";
        }

        public string GiveTreat()
        {
            return $"Here {this.Name} have some treats.";
        }
    }
}
