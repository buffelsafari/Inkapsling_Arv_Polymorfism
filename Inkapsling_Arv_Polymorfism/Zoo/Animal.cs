using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo
{
    abstract class Animal
    {
        private string name;
        private int ownerId;
        private double weight;
        private double length;


        public string Name 
        {
            get=>name;
            set
            {
                name = value;
            }
        }
        public int OwnerId
        {
            get => ownerId;
            set
            {
                ownerId = value;
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                weight = value;
            }
        }
        public double Length
        {
            get => length;
            set
            {
                length = value;
            }
        }

        public abstract void DoSound();

        public Animal(string name, int ownerId, double weight, double length)
        {
            this.name = name;
            this.ownerId = ownerId;
            this.weight = weight;
            this.length = length;
        }

        public virtual string Stats()
        {
            string[] type = this.GetType().ToString().Split('.');
            return $"type:{type[type.Length-1]}\tname:{this.name}\townerId:{this.ownerId}\tweight:{this.weight}\tlength:{this.length}";
        }
        

    }
}
