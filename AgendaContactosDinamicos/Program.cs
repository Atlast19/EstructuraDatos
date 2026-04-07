using AgendaContactosDinamicos.Clases;

namespace AgendaContactosDinamicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaAgenda agenda = new ListaEnlazadaAgenda();

            Console.WriteLine("AGENDA DE CONTACTOS\n");
 

            // --- AGREGAR CONTACTOS ---
            Console.WriteLine(">> Agregando contactos...\n");
            agenda.AgregarContacto("Ana García", "809-555-1001", "ana.garcia@email.com");
            agenda.AgregarContacto("Luis Martínez", "829-555-2002", "luis.m@correo.com");
            agenda.AgregarContacto("María Rodríguez", "849-555-3003", "maria.r@mail.com");
            agenda.AgregarContacto("Carlos Peña", "809-555-4004", "carlos.p@web.com");

            // --- MOSTRAR TODOS LOS CONTACTOS ---
            Console.WriteLine(">> Mostrando todos los contactos...");
            agenda.MostrarContactos();

            // --- ELIMINAR UN CONTACTO EXISTENTE ---
            Console.WriteLine(">> Eliminando a 'Luis Martínez'...");
            agenda.EliminarContacto("Luis Martínez");

            // --- INTENTAR ELIMINAR UN CONTACTO QUE NO EXISTE ---
            Console.WriteLine(">> Intentando eliminar a 'Pedro López' (no existe)...");
            agenda.EliminarContacto("Pedro López");

            // --- MOSTRAR CONTACTOS TRAS LA ELIMINACIÓN ---
            Console.WriteLine(">> Mostrando contactos tras la eliminación...");
            agenda.MostrarContactos();

            // --- ELIMINAR LA CABEZA DE LA LISTA ---
            Console.WriteLine(">> Eliminando al primer contacto ('Ana García')...");
            agenda.EliminarContacto("Ana García");

            // --- MOSTRAR ESTADO FINAL ---
            Console.WriteLine(">> Estado final de la agenda:");
            agenda.MostrarContactos();
        }
    }
}
