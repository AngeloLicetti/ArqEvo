using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Decorator
{
    abstract class AbstractDecorator : Pizza
    {
        protected double precio;
        protected Pizza decorado;

        public AbstractDecorator(Pizza decorado)
        {
            this.decorado = decorado;
        }

        public abstract double Precio();
    }
}
