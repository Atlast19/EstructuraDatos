
namespace DepreciacionSaldoDecrecitente
{
    public class CalculoDepreciacionDecreciente : IDepreciacionDecreciente
    {
        public decimal ValorInicial { get; }
        public decimal TasaDeprecion { get; }
        public int años { get; }

        public CalculoDepreciacionDecreciente(decimal ValorInicial, decimal TasaDeprecion, int años)
        {
            this.ValorInicial = ValorInicial;
            this.TasaDeprecion = TasaDeprecion;
            this.años = años;
        }

        public decimal CalcularValor(int t)
        {
            decimal r = 1 - (TasaDeprecion / 100m);

            if (t < 0)
                throw new ArgumentException("Los años no pueden ser negativos");

            if (t == 0)
                return ValorInicial;

            return CalcularValor(t - 1) * r;
        }

        public decimal ObtenerValorFinal()
        {
            return CalcularValor(años);
        }
    }
}
