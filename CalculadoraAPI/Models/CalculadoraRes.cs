namespace CalculadoraAPI.Models
{
    public class CalculadoraRes
    {
        public double R { get; set; }
        public string Operacion { get; set; }

        // Constructor de la clase
        public CalculadoraRes()
        {
            // Inicializar propiedades con valores predeterminados
            this.R = 0;
            this.Operacion = string.Empty;
        }
    }
}
