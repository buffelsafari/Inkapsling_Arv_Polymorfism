using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Error
{
    class DivineTruthError : UserError
    {
        public override string UEMessage() => "Unholy input";
        
    }
}
