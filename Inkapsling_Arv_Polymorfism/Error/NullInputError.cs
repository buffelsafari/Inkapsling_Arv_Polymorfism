using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Error
{
    class NullInputError : UserError
    {
        public override string UEMessage() => "Input cannot be NULL";
        
    }
}
