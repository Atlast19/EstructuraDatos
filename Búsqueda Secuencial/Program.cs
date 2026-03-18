namespace Búsqueda_Secuencial
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Ana", "Luis", "Carlos", "Maria", "Jose" };
            string nombreBuscado = "Maria";

            bool encontrado = false;

            foreach (string nombre in nombres)
            {
                if (nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
                Console.WriteLine("El estudiante llegó.");
            else
                Console.WriteLine("El estudiante NO está en la lista.");
        }
    }
}
