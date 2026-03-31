

namespace Atención_de_clientes_en_un_banco.Clases
{
    public class Banco
    {
        private Queue<string> colaClientes = new Queue<string>();

        // Agregar cliente (enqueue)
        public void LlegarCliente(string nombre)
        {
            colaClientes.Enqueue(nombre);
            Console.WriteLine(nombre + " ha llegado al banco.");
        }

        // Atender cliente (dequeue)
        public void AtenderCliente()
        {
            if (colaClientes.Count > 0)
            {
                string cliente = colaClientes.Dequeue();
                Console.WriteLine("Atendiendo a: " + cliente);
            }
            else
            {
                Console.WriteLine("No hay clientes en espera.");
            }
        }

        // Mostrar clientes en espera
        public void MostrarCola()
        {
            Console.WriteLine("\nClientes en espera:");
            foreach (var cliente in colaClientes)
            {
                Console.WriteLine(cliente);
            }
        }

        // Mostrar cliente actual
        public void ClienteActual()
        {
            if (colaClientes.Count > 0)
            {
                Console.WriteLine("Cliente actual: " + colaClientes.Peek());
            }
            else
            {
                Console.WriteLine("No hay clientes en espera.");
            }
        }
    }
}
