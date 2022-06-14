using GeometriaAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometriaAPITest
{
    [TestClass]
    public class TrianguloTest
    {

        Triangulo triangulo = new Triangulo();
        [TestMethod]
        public void TrianguloCalcularAreaTestAccept()
        {
            double esperado = 10;
            string[] medidas = {"4","5"};
            double resultado = triangulo.CalcularArea(medidas);

            Assert.AreEqual(esperado,resultado);
        }

        [TestMethod]
        public void TrianguloCalcularPerimetroCorreto()
        {
            double esperado = 12;
            string[] medidas = {"4","4","4"};
            double resultado = triangulo.CalcularPerimetro(medidas);

            Assert.AreEqual(esperado,resultado);
        }
        
    }
}