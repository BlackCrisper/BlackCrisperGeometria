using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetanguloController : Controller
    {
        [HttpGet]
        [Route("GetArea")]
       public ActionResult<string> GetArea(double basev, double alturav)
       {
            Retangulo retangulo = new Retangulo();

            string[] valores = {basev.ToString(), alturav.ToString()};

            return (retangulo.CalcularArea(valores)).ToString();
       }

        [HttpGet]
        [Route("GetPerimetro")]
       public ActionResult<string> GetPerimetro(double basev, double alturav)
       {
            Retangulo retangulo = new Retangulo();

            string[] valores = {basev.ToString(), alturav.ToString()};

            return (retangulo.CalcularPerimetro(valores)).ToString();
       }


    }
}