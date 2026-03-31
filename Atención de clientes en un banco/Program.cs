
using Atención_de_clientes_en_un_banco.Clases;

namespace Atención_de_clientes_en_un_banco
{
    public class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            banco.LlegarCliente("Juan");
            banco.LlegarCliente("María");
            banco.LlegarCliente("Carlos");

            banco.MostrarCola();

            banco.ClienteActual();

            banco.AtenderCliente();
            banco.MostrarCola();
        }
    }
}
