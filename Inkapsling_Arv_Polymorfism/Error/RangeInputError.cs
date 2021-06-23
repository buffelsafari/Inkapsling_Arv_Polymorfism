using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Error
{
    class RangeInputError : UserError
    {
        public override string UEMessage() => "Input is outside the defined range";
        
    }
}
