using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab08_Regex
{
    class EliminarBlancos : AbstractFilter
    {
        public override string filtrar(string input)
        {
            return Regex.Replace(input, " +", " ");
        }
    }
}
