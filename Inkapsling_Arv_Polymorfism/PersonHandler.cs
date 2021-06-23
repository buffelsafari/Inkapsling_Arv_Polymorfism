using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism
{
    class PersonHandler
    {
        
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person p = new Person();
            p.Age = age;
            p.FName = fname;
            p.LName = lname;
            p.Height = height;
            p.Weight = weight;
            return p;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetName(Person pers, string fname, string lname)
        {
            pers.FName = fname;
            pers.LName = lname;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public void PrintPersonalInfo(Person pers)
        {
            Console.WriteLine($"Name:{pers.FName} {pers.LName}");
            Console.WriteLine($"Age:{pers.Age}years Height:{pers.Height:0.00}m Weight{pers.Weight:0}kg");
        }
    }
}
