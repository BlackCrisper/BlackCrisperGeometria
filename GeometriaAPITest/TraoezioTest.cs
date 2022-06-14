using GeometriaAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometriaAPITest
{

    [TestClass]
    public class TraoezioTest
    {
        Trapezio trapezio = new Trapezio();
        [TestMethod]
        public void TrapezioCalcularAreaTestAccept()
        {
            double esperado = 20;
            string[] medidas = {"4","4", "5"};
            double resultado = trapezio.CalcularArea(medidas);

            Assert.AreEqual(esperado,resultado);
        }

        [TestMethod]
        public void TrapezioCalcularPerimetroCorreto()
        {
            double esperado = 7;
            string[] medidas = {"3","2","1","1"};
            double resultado = trapezio.CalcularPerimetro(medidas);

            Assert.AreEqual(esperado,resultado);
        }
    }
}