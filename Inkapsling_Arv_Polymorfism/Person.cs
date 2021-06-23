using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        #region properties
        public int Age
        {
            get => age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be greater then 1");
                }
                this.age = value;
            }
        }
        public string FName
        {
            get => fName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name length must be 2-10");
                }
                fName = value;
            }
        }
        public string LName
        {
            get => lName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name length must be 3-15");
                }
                lName = value;
            }
        }

        public double Height
        {
            get=>height;
            set
            {
                height = value;
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

        #endregion


    }
}
