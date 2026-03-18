namespace Revisar_si_un_producto_está_agotado
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] agotados = { "Laptop", "Mouse", "Teclado", "Monitor" };
            string producto = "Teclado";

            int posicion = -1;

            for (int i = 0; i < agotados.Length; i++)
            {
                if (agotados[i].Equals(producto, StringComparison.OrdinalIgnoreCase))
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
                Console.WriteLine($"Producto agotado en la posición {posicion}");
            else
                Console.WriteLine("Producto disponible.");
        }
    }
}
