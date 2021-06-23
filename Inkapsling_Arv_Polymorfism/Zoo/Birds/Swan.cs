using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo.Birds
{
    class Swan:Bird
    {
        private double neckLength;

        public double NeckLength
        {
            get => neckLength;
            set
            {
                neckLength = value;
            }
        }

        public Swan(string name, int ownerId, double weight, double length, double cargoWeight, double neckLength) : base(name, ownerId, weight, length, cargoWeight)
        {
            this.neckLength = neckLength;
        }

        public override string Stats()
        {
            return base.Stats() + $"\tneckLength:{this.neckLength}";
        }
    }
}
