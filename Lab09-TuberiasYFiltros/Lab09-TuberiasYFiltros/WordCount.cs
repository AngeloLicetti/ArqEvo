using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab09_TuberiasYFiltros
{
    class WordCount : AbstractFilter
    {
        public override string filtrar(string input)
        {
            Regex wordCount = new Regex("(\\w|[áéíóú])+");
            return input + " Palabras: " + wordCount.Matches(input).Count;
        }
    }
}
