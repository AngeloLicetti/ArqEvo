using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_PatronEstado
{
    public class Puerta
    {
        private EstadoAbstracto estado;

        public string getEstado()
        {
            return estado.ToString();
        }

        public void setEstado(EstadoAbstracto estado)
        {
            this.estado = estado;
        }

        public void abrir()
        {
            estado.abrir();
        }

        public void cerrar()
        {
            estado.cerrar();
        }

        public void armar()
        {
            estado.armar();
        }

        public void desarmar()
        {
            estado.desarmar();
        }

        public void reparar()
        {
            estado.reparar();
        }

        public void test()
        {
            estado.test();
        }

        public void endTest()
        {
            estado.endTest();
        }
    }
}
