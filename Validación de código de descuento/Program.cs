namespace Validación_de_código_de_descuento
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] codigos = { 1001, 1005, 1010, 1020, 1050 };
            int codigoBuscado = 1010;

            int inicio = 0, fin = codigos.Length - 1;
            bool valido = false;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (codigos[medio] == codigoBuscado)
                {
                    valido = true;
                    break;
                }
                else if (codigos[medio] < codigoBuscado)
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }

            Console.WriteLine(valido ? "Código válido" : "Código inválido");
        }
    }
}
