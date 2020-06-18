using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Patron_COR
{
    class Handler100000 : Handler
    {
        private Handler siguiente = null;

        public Handler100000(Handler siguiente)
        {
            this.siguiente = siguiente;
        }

        public override double calcularImpuesto(double monto)
        {
            if (monto <= 99999)
            {
                return monto * 0.03;
            }
            return siguiente.calcularImpuesto(monto);
        }
    }
}
