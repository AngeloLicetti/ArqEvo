using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Decorator
{
    class Jalapeño : AbstractDecorator
    {
        public Jalapeño(Pizza decorado) : base(decorado)
        {

        }

        public override double Precio()
        {
            return decorado.Precio() + 2.5;
        }
    }
}
