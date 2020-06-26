using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_TuberiasYFiltros
{
    class StringPipe : AbstractPipe
    {
        public override int add(AbstractFilter f)
        {
            filtros.Add(f);
            return filtros.Count;
        }

        public override string filtrar(string input)
        {
            string output = input;
            foreach(AbstractFilter filtro in filtros)
            {
                output = filtro.filtrar(output);
            }
            return output;
        }

        public override void reset()
        {
            filtros.Clear();
        }
    }
}
