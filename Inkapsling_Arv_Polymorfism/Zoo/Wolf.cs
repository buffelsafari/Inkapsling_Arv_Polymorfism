using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Zoo
{
    
    class Wolf : Animal
    {
        public enum Status
        { 
            alphaWolf,
            betaWolf,
            loneWolf
        }



        private Status socialStatus;

        public Status SocialStatus
        {
            get => socialStatus;
            set
            {
                socialStatus = value;
            }
        }

        public Wolf(string name, int ownerId, double weight, double length, Status status) : base(name, ownerId, weight, length)
        {
            this.socialStatus = status;
        }

        public override void DoSound()
        {
            string[] str = this.GetType().ToString().Split('.');
            Console.WriteLine($"The {str[str.Length - 1]} named {this.Name} howls at the moon.");            
        }

        public override string Stats()
        {
            return base.Stats() + $"\tstatus={this.socialStatus}";
        }
    }
}
