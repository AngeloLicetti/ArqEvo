using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_PatronEstado
{
    public abstract class EstadoAbstracto
    {
        protected Puerta miPuerta;
        public abstract bool abrir();
        public abstract bool cerrar();
        public abstract bool armar();
        public abstract bool desarmar();
        public abstract bool reparar();
        public abstract bool test();
        public abstract bool endTest();
    }
}
