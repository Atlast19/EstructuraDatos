namespace InteresCompuesto
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal capital = 10000m;
            decimal tasa = 5m;
            int anios = 3;

            IcalculoInteresCompuesto inversion = new CalculoInteresCompuesto(capital, tasa, anios);

            decimal resultado = inversion.CalcularMonto(anios);

            Console.WriteLine($"Monto final despues de {anios} años: {resultado:C}");
        }
    }
}
