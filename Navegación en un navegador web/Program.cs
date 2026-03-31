using Atención_de_clientes_en_un_banco.Clases;

namespace Navegación_en_un_navegador_web
{
    public class Program
    {
        static void Main(string[] args)
        {
            Navegador nav = new Navegador();

            nav.VisitarPagina("google.com");
            nav.VisitarPagina("youtube.com");
            nav.VisitarPagina("github.com");

            nav.MostrarHistorial();

            nav.Regresar();
            nav.MostrarHistorial();
        }
    }
}
