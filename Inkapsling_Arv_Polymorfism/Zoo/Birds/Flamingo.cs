using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo.Birds
{
    class Flamingo:Bird
    {
        private double legLength;

        public double LegLength
        {
            get => legLength;
            set
            {
                legLength = value;
            }
        }
        public Flamingo(string name, int ownerId, double weight, double length, double cargoWeight, double legLength) : base(name, ownerId, weight, length, cargoWeight)
        {
            this.legLength = legLength;
        }

        public override string Stats()
        {
            return base.Stats() + $"\tlegLength:{this.legLength}";
        }
    }
}
