namespace InteresCompuesto
{
    public class CalculoInteresCompuesto : IcalculoInteresCompuesto
    {
        public decimal CapitalInicial { get; set; }
        public decimal TasaInteres { get; set; }
        public int Periodo { get; set; }

        public CalculoInteresCompuesto(decimal CapitalInicial, decimal TasaInteres, int Periodo)
        {
            this.CapitalInicial = CapitalInicial;
            this.TasaInteres = TasaInteres;
            this.Periodo = Periodo;
        }

        public decimal CalcularMonto(int n)
        {
            decimal i = TasaInteres / 100m;

            if (n < 0)
                throw new ArgumentNullException("El monto ingresado no puede ser menor que 0");

            if (n == 0)
                return CapitalInicial;

            return CalcularMonto(n - 1) * (1 + i);
        }

        public decimal ObtenerMontoFinal()
        {
            return CalcularMonto(Periodo);
        }
    }
}
