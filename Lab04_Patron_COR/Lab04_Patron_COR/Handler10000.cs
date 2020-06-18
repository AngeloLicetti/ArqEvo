using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Patron_COR
{
    class Handler10000 : Handler
    {
        private Handler siguiente = null;

        public Handler10000(Handler siguiente)
        {
            this.siguiente = siguiente;
        }

        public override double calcularImpuesto(double monto)
        {
            if (monto <= 9999)
            {
                return monto * 0.02;
            }
            return siguiente.calcularImpuesto(monto);
        }
    }
}
