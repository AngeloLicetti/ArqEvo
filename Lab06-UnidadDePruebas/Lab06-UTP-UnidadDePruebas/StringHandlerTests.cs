using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab06_UTP_UnidadDePruebas
{
    [TestClass]
    public class StringHandlerTests
    {
        [TestMethod]
        public void reverseTest1()
        {
            string testInput = "hola";
            string expectedResult = "aloh";

            string testResult = Lab06_UnidadDePruebas.StringHandler.reverse(testInput);

            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void reverseTest2()
        {
            string testInput = "angelo";
            string expectedResult = "olegna";

            string testResult = Lab06_UnidadDePruebas.StringHandler.reverse(testInput);

            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void reverseTest3()
        {
            string testInput = "";
            string expectedResult = "nullString";

            string testResult = Lab06_UnidadDePruebas.StringHandler.reverse(testInput);

            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void trimTest1()
        {
            string testInput = "angelo ";
            string expectedResult = "angelo";

            string testResult = Lab06_UnidadDePruebas.StringHandler.trim(testInput);

            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void trimTest2()
        {
            string testInput = " angelo";
            string expectedResult = "angelo";

            string testResult = Lab06_UnidadDePruebas.StringHandler.trim(testInput);

            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void trimTest3()
        {
            string testInput = " angelo ";
            string expectedResult = "angelo";

            string testResult = Lab06_UnidadDePruebas.StringHandler.trim(testInput);

            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void trimTest4()
        {
            string testInput = " ";
            string expectedResult = "";

            string testResult = Lab06_UnidadDePruebas.StringHandler.trim(testInput);

            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void trimTest5()
        {
            string testInput = "   ";
            string expectedResult = "";

            string testResult = Lab06_UnidadDePruebas.StringHandler.trim(testInput);

            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void trimTest6()
        {
            string testInput = "";
            string expectedResult = "nullString";

            string testResult = Lab06_UnidadDePruebas.StringHandler.trim(testInput);

            Assert.AreEqual(expectedResult, testResult);
        }
    }
}
