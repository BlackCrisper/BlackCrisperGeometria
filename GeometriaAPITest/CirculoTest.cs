using GeometriaAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometriaAPITest
{
    public class CirculoTest
    {
        Circulo circulo = new Circulo();
        [TestMethod]
        public void CirculoCalcularAreaTestAccept()
        {
            double esperado = 50.24;
            string[] medidas = {"4"};
            double resultado = circulo.CalcularArea(medidas);

            Assert.AreEqual(esperado,resultado);
        }

        [TestMethod]
        public void CirculoCalcularPerimetroCorreto()
        {
            double esperado = 25.12;
            string[] medidas = {"4"};
            double resultado = circulo.CalcularPerimetro(medidas);

            Assert.AreEqual(esperado,resultado);
        }
    }
}