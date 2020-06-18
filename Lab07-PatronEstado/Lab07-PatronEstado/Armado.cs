namespace Lab07_PatronEstado
{
    public class Armado : EstadoAbstracto
    {
        public Armado(Puerta puerta)
        {
            miPuerta = puerta;
        }

        public override bool abrir()
        {
            miPuerta.setEstado(new Emergencia(miPuerta));
            return true;
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
            miPuerta.setEstado(new Cerrado(miPuerta));
            return true;
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