using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab09_TuberiasYFiltros
{
    class EliminarBlancos : AbstractFilter
    {
        public override string filtrar(string input)
        {
            return Regex.Replace(input, " +", " ");
        }
    }
}
