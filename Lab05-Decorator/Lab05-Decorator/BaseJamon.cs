using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Decorator
{
    class BaseJamon : Pizza
    {
        private double precio;
        public BaseJamon()
        {
            precio = 10;
        }

        public double Precio()
        {
            return precio;
        }
    }
}
