using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo
{
    class WolfMan : Wolf, Person
    {
        public WolfMan(string name, int ownerId, double weight, double length, Status status) : base(name, ownerId, weight, length, status)
        {
            
        }

        public void Talk()
        {
            Console.WriteLine($"{this.Name} mutters something about chinese virus.");          
        }
    }
}
