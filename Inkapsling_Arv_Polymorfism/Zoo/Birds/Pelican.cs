using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo.Birds
{
    class Pelican:Bird
    {
        private double beekVolume;

        public double BeekVolume
        {
            get => beekVolume;
            set
            {
                beekVolume = value;
            }
        }

        public Pelican(string name, int ownerId, double weight, double length, double cargoWeight, double beekVolume) : base(name, ownerId, weight, length, cargoWeight)
        {
            this.beekVolume = beekVolume;
        }

        public override string Stats()
        {
            return base.Stats() + $"\tbeekVolume:{this.beekVolume}";
        }
    }
}
