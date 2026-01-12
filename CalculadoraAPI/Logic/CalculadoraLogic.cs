namespace CalculadoraAPI.Logic
{
    public class CalculadoraLogic
    {
        public string Suma(double n1, double n2)
        {
            double resultado = n1 + n2;
            return $"{n1} + {n2} = {n1 + n2}";
        }

        public string Resta(double n1, double n2)
        {
            double resultado = n1 - n2;
            return $"{n1} - {n2} = {n1 - n2}";
        }

        public string Multiplicacion(double n1, double n2)
        {
            double resultado = n1 * n2;
            return $"{n1} * {n2} = {n1 * n2}";
        }

        public string Division(double n1, double n2)
        {
            if (n2 == 0)
            {
                return "No se puede dividir entre cero.";
            }
            else
            {
                double resultado = n1 / n2;
                return $"{n1} / {n2} = {n1 / n2}";
            }
        }
    }
}
