using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrianguloController : Controller
    {
       [HttpGet]
        [Route("GetArea")]
       public ActionResult<string> GetArea(double basev, double alturav)
       {
            Triangulo triangulo = new Triangulo();

            string[] valores = {basev.ToString(), alturav.ToString()};

            return (triangulo.CalcularArea(valores)).ToString();
       }

        [HttpGet]
        [Route("GetPerimetro")]
       public ActionResult<string> GetPerimetro(double lado1, double lado2, double lado3)
       {
            Triangulo triangulo = new Triangulo();

            string[] valores = {lado1.ToString(), lado2.ToString(), lado3.ToString()};

            return (triangulo.CalcularPerimetro(valores)).ToString();
       }

    }
}