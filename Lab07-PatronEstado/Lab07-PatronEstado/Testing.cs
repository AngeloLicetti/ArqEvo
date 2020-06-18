namespace Lab07_PatronEstado
{
    public class Testing : EstadoAbstracto
    {
        public Testing(Puerta miPuerta)
        {
            this.miPuerta = miPuerta;
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
            return false;
        }

        public override bool test()
        {
            return false;
        }

        public override bool endTest()
        {
            miPuerta.setEstado(new Cerrado(miPuerta));
            return true;
        }
    }
}