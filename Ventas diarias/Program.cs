namespace Ventas_diarias
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Ventas diarias
             * Se requiere crear un programa que registre las ventas de una tienda durante 7 días y determina:
             * 
             * El total vendido en la semana
             * El promedio diari
             * El día con la venta máxima*/

            double[] Ventas = new double[7];
            double TotalVentas = 0;
            double VentaMax;
            int DiaMax = 0;

            for (int i = 0; i < 7; i++) 
            {
                Console.Write($"Ingrese la venta del dia {i + 1}: ");
                Ventas[i] = double.Parse(Console.ReadLine());
                TotalVentas += Ventas[i];
            }

            VentaMax = Ventas[0];

            for (int i = 1; i < 7; i++)
            {
                if (Ventas[i] > VentaMax)
                {
                    VentaMax = Ventas[i];
                    DiaMax = i;
                }
            }

            double promedio = TotalVentas / 7;

            Console.WriteLine();
            Console.WriteLine("RESULTADOS:");
            Console.WriteLine($"Total vendido en la semana: {TotalVentas}");
            Console.WriteLine($"Promedio diario: {promedio}");
            Console.WriteLine($"Dia con mayor venta: Dia {DiaMax + 1} con {VentaMax}");
        }
    }
}
