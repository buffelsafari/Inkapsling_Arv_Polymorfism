using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Arv_Polymorfism.Error
{
    class NumericInputError : UserError
    {
        public override string UEMessage() => "You tried to use a numeric input in a text only field.This fired an error!";

    }
}
