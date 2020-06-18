using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_PatronEstado
{
    public class Emergencia : EstadoAbstracto
    {
        public Emergencia(Puerta puerta)
        {
            miPuerta = puerta;
        }

        public override bool abrir()
        {
            return false;
        }

        public override bool armar()
        {
            return false;
        }

        public override bool cerrar()
        {
            return false;
        }

        public override bool desarmar()
        {
            return false;
        }

        public override bool reparar()
        {
            miPuerta.setEstado(new Cerrado(miPuerta));
            return true;
        }

        public override bool test()
        {
            return false;
        }

        public override bool endTest()
        {
            return false;
        }
    }
}
