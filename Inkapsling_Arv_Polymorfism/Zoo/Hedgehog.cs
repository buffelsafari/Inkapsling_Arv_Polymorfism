using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo
{
    class Hedgehog : Animal
    {
        private int spikeCount;

        public int SpikeCount
        {
            get => spikeCount;
            set
            {
                spikeCount = value;
            }
        }

        public Hedgehog(string name, int ownerId, double weight, double length, int spikeCount) : base(name, ownerId, weight, length)
        {
            this.spikeCount = spikeCount;
        }

        public override void DoSound()
        {
            string[] str = this.GetType().ToString().Split('.');
            Console.WriteLine($"The {str[str.Length - 1]} named {this.Name} says (((woff))).(in a small voice)");
            
        }

        public override string Stats()
        {
            return base.Stats() + $"\tspikeCount:{this.spikeCount}";
        }
    }
}
