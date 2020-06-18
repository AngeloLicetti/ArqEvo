using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Decorator
{
    class Anchoas : AbstractDecorator
    {
        public Anchoas(Pizza decorado): base(decorado)
        {
            
        }

        public override double Precio()
        {
            return decorado.Precio() + 2;
        }
    }
}
