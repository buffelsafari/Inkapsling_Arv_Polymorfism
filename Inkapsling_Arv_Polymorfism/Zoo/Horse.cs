using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo
{
    class Horse : Animal
    {
        private double faceLength;

        public double FaceLength
        {
            get => faceLength;
            set
            {
                faceLength = value;
            }
        }

        public Horse(string name, int ownerId, double weight, double length, double faceLength) : base(name, ownerId, weight, length)
        {
            this.faceLength = faceLength;
        }
        public override void DoSound()
        {
            string[] str = this.GetType().ToString().Split('.');
            Console.WriteLine($"The {str[str.Length - 1]} named {this.Name} says neigh.");            
        }

        public override string Stats()
        {
            return base.Stats() + $"\tfaceLength:{this.faceLength}";
        }
    }
}
