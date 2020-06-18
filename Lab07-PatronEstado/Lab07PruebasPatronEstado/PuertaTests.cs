using System;
using Lab07_PatronEstado;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab07PruebasPatronEstado
{
    [TestClass]
    public class PuertaTests
    {
        [TestMethod]
        public void AbrirTest()
        {
            Puerta puerta = new Puerta();
            puerta.setEstado(new Cerrado(puerta));

            string estadoEsperado = "Lab07_PatronEstado.Abierto";

            puerta.abrir();
            string estadoResultado = puerta.getEstado();

            Assert.AreEqual(estadoEsperado, estadoResultado);
        }

        [TestMethod]
        public void CerrarTest()
        {
            Puerta puerta = new Puerta();
            puerta.setEstado(new Abierto(puerta));

            string estadoEsperado = "Lab07_PatronEstado.Cerrado";

            puerta.cerrar();
            string estadoResultado = puerta.getEstado();

            Assert.AreEqual(estadoEsperado, estadoResultado);
        }

        [TestMethod]
        public void ArmarTest()
        {
            Puerta puerta = new Puerta();
            puerta.setEstado(new Cerrado(puerta));

            string estadoEsperado = "Lab07_PatronEstado.Armado";

            puerta.armar();
            string estadoResultado = puerta.getEstado();

            Assert.AreEqual(estadoEsperado, estadoResultado);
        }
    }
}
