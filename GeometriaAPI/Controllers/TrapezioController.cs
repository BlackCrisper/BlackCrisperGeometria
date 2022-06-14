using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrapezioController : Controller
    {
        [HttpGet]
        [Route("GetArea")]
       public ActionResult<string> GetArea(double baseMaior, double baseMenor, double alturav)
       {
            Trapezio trapezio = new Trapezio();

            string[] valores = {baseMaior.ToString(), baseMenor.ToString(), alturav.ToString()};

            return (trapezio.CalcularArea(valores)).ToString();
       }

        [HttpGet]
        [Route("GetPerimetro")]
       public ActionResult<string> GetPerimetro(double baseMaior, double baseMenor, double lado1, double lado2)
       {
            Trapezio trapezio = new Trapezio();

            string[] valores = {baseMaior.ToString(), baseMenor.ToString(), lado1.ToString(), lado2.ToString()};

            return (trapezio.CalcularPerimetro(valores)).ToString();
       }


    }
}