using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_TuberiasYFiltros
{
    public abstract class AbstractPipe
    {
        protected List<AbstractFilter> filtros;

        public List<AbstractFilter> Filtros { get => filtros; set => filtros = value; }

        public AbstractPipe()
        {
            filtros = new List<AbstractFilter>();
        }

        public abstract int add(AbstractFilter F);
        public abstract string filtrar(string input);

        public abstract void reset();
    }
}
