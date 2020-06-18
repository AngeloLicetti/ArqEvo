using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Decorator
{
    class Tocino : AbstractDecorator
    {
        public Tocino(Pizza decorado) : base(decorado)
        {

        }

        public override double Precio()
        {
            return decorado.Precio() + 3;
        }
    }
}
