using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_PatronEstado
{
    public class Cerrado : EstadoAbstracto
    {
        public Cerrado(Puerta puerta)
        {
            miPuerta = puerta;
        }

        public override bool abrir()
        {
            miPuerta.setEstado(new Abierto(miPuerta));
            return true;
        }

        public override bool armar()
        {
            miPuerta.setEstado(new Armado(miPuerta));
            return true;
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
            return false;
        }

        public override bool test()
        {
            miPuerta.setEstado(new Testing(miPuerta));
            return true;
        }

        public override bool endTest()
        {
            return false;
        }
    }
}
