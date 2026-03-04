
namespace DepreciacionSaldoDecrecitente
{
    public interface IDepreciacionDecreciente
    {
        decimal CalcularValor(int t);
        decimal ObtenerValorFinal();
    }
}
