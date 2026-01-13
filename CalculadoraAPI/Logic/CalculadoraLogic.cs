using CalculadoraAPI.Models;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraAPI.Logic
{
    public class CalculadoraLogic
    {
        private double N1, N2, Respuesta;
        public string Op_Log, Op_Sym;

        public CalculadoraRes Calcular(CalculadoraRequest request, int Op)
        {
            N1 = request.N1;
            N2 = request.N2;
            switch (Op)
            {
                case 1:
                    Respuesta = N1 + N2;
                    Op_Sym = "+";
                    break;
                case 2:
                    Respuesta = N1 - N2;
                    Op_Sym = "-";
                    break;
                case 3:
                    Respuesta = N1 * N2;
                    Op_Sym = "*";
                    break;
                case 4:
                    if (N2 == 0)
                    {
                        return new CalculadoraRes
                        {
                            R = 0,
                            Operacion = "ERROR: No se puede dividir entre cero."
                        };
                    }
                    Respuesta = N1 / N2;
                    Op_Sym = "/";
                    break;
                default:
                    return new CalculadoraRes
                    {
                        R = 0,
                        Operacion = "ERROR: Operación no válida."
                    };
            }

            Op_Log = $"{N1} {Op_Sym} {N2} = {Respuesta}";

            return new CalculadoraRes
            {
                R = Respuesta,
                Operacion = Op_Log
            };
        }
    };
}
