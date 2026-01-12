using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CalculadoraAPI.Models;

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
                Operacion = $"{request.N1} - {request.N2} = {request.N1 - request.N2}"
            };
            return Ok(resultado);
        }

        [HttpPost("Multiplicacion")]
        public ActionResult<CalculadoraRes> Multiplicacion([FromBody] CalculadoraRequest request)
        {
            var resultado = new CalculadoraRes
            {
                R = request.N1 * request.N2,
                Operacion = $"{request.N1} * {request.N2} = {request.N1 * request.N2}"
            };
            return Ok(resultado);
        }

        [HttpPost("Division")]
        public ActionResult<CalculadoraRes> Division([FromBody] CalculadoraRequest request)
        {
            if (request.N2 == 0)
            {
                return BadRequest("No se puede dividir entre cero.");
            }
            var resultado = new CalculadoraRes
            {
                R = request.N1 / request.N2,
                Operacion = $"{request.N1} / {request.N2} = {request.N1 / request.N2}"
            };
            return Ok(resultado);
        }
    }




}
