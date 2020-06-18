using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Patron_COR
{
    class Handler1000000 : Handler
    {
        public override double calcularImpuesto(double monto)
        {
            return monto * 0.04;
        }
    }
}
