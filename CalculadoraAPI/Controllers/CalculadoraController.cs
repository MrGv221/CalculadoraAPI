using Microsoft.AspNetCore.Mvc;
using CalculadoraAPI.Models;
using CalculadoraAPI.Logic;

namespace CalculadoraAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private CalculadoraLogic Res = new CalculadoraLogic();

        [HttpPost]
        public CalculadoraRes Suma(CalculadoraRequest request)
        {
            return Res.Calcular(request, 1);
        }

        [HttpPost]
        public CalculadoraRes Resta(CalculadoraRequest request)
        {
            return Res.Calcular(request, 2);
        }

        [HttpPost]
        public CalculadoraRes Multiplicacion(CalculadoraRequest request)
        {
           return Res.Calcular(request, 3);
        }

        [HttpPost]
        public CalculadoraRes Division(CalculadoraRequest request)
        {
            return Res.Calcular(request, 4);
        }
    }
}
