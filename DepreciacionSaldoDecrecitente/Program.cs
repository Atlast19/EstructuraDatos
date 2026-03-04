namespace DepreciacionSaldoDecrecitente
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal valorInicial = 1000m;
            decimal tasaDepreciacion = 20m;
            int anios = 3;

            IDepreciacionDecreciente activo = new CalculoDepreciacionDecreciente(valorInicial, tasaDepreciacion, anios);

            decimal resultado = activo.CalcularValor(anios);

            Console.WriteLine("Valor inicial: " + valorInicial.ToString("C"));
            Console.WriteLine("Depreciacion anual: " + tasaDepreciacion + "%");
            Console.WriteLine("Años transcurridos: " + anios);
            Console.WriteLine("Valor del activo despues de " + anios + " años: " + resultado.ToString("C"));
        }
    }
}
