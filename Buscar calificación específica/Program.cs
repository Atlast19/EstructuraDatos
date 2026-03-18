namespace Buscar_calificación_específica
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] notas = { 50, 60, 70, 80, 90, 100 };
            int notaBuscada = 80;

            int inicio = 0;
            int fin = notas.Length - 1;
            bool encontrado = false;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (notas[medio] == notaBuscada)
                {
                    encontrado = true;
                    break;
                }
                else if (notas[medio] < notaBuscada)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            Console.WriteLine(encontrado ? "Nota encontrada" : "Nota no encontrada");
        }
    }
}
