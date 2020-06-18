namespace Lab07_PatronEstado
{
    public class Abierto : EstadoAbstracto
    {
        public Abierto(Puerta puerta)
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
            miPuerta.setEstado(new Cerrado(miPuerta));
            return true;
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
            return false;
        }

        public override bool endTest()
        {
            return false;
        }
    }
}