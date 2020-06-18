using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Singleton
{
    class Singleton
    {
        private static Singleton instancia = null;

        private int contadorDeSesiones = 0;

        private Singleton()
        {
                
        }

        public static Singleton Instancia()
        {
            if (instancia == null)
                instancia = new Singleton();
            return instancia;
        }

        public int Abrir()
        {
            return ++contadorDeSesiones;
        }

        public int Cerrar()
        {
            return --contadorDeSesiones;
        }
    }
}
