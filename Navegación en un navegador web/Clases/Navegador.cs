
namespace Atención_de_clientes_en_un_banco.Clases
{
    public class Navegador
    {
        private Stack<string> historial = new Stack<string>();

        // Visitar nueva página (push)
        public void VisitarPagina(string url)
        {
            historial.Push(url);
            Console.WriteLine("Visitando: " + url);
        }

        // Regresar a la página anterior (pop)
        public void Regresar()
        {
            if (historial.Count > 1)
            {
                historial.Pop(); // elimina la actual
                Console.WriteLine("Regresando a: " + historial.Peek());
            }
            else
            {
                Console.WriteLine("No hay páginas anteriores.");
            }
        }

        public void MostrarHistorial()
        {
            Console.WriteLine("\nHistorial de navegación:");
            foreach (var pagina in historial)
            {
                Console.WriteLine(pagina);
            }
        }
    }
}
