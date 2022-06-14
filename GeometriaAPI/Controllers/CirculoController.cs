using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CirculoController : Controller
    {
       [HttpGet]
        [Route("GetArea")]
       public ActionResult<string> GetArea(double raio)
       {
            Circulo circulo = new Circulo();

            string[] valores = {raio.ToString()};

            return (circulo.CalcularArea(valores)).ToString();
       }
        [HttpGet]
        [Route("GetPerimetro")]
        public ActionResult<string> GetPerimetro(double raio)
       {
            Circulo circulo = new Circulo();

            string[] valores = {raio.ToString()};

            return (circulo.CalcularPerimetro(valores)).ToString();
       }

    }
}