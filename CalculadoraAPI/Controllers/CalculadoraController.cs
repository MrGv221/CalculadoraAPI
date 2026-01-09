using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// Comentarios de Prueba
namespace CalculadoraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        [HttpPost("Suma")]
        public ActionResult<CalculadoraRes> Suma([FromBody] CalculadoraRequest request)
        {
            var resultado = new CalculadoraRes
            {
                R = request.N1 + request.N2,
                Operacion = $"{request.N1} + {request.N2} = {request.N1 + request.N2}"
            };
            return Ok(resultado);
        }

        [HttpPost("Resta")]
        public ActionResult<CalculadoraRes> Resta([FromBody] CalculadoraRequest request)
        {
            var resultado = new CalculadoraRes
            {
                R = request.N1 - request.N2,
                Operacion = $"{request.N1} + {request.N2} = {request.N1 - request.N2}"
            };
            return Ok(resultado);
        }
    }

    public class CalculadoraRequest
    {
        public double N1 { get; set; }
        public double N2 { get; set; }
    }

    public class CalculadoraRes
    {
        public double R { get; set; }
        public string Operacion { get; set; }
    }
}
