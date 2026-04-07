

namespace AgendaContactosDinamicos.Clases
{
    public class ListaEnlazadaAgenda
    {
        private Nodo cabeza;

        public ListaEnlazadaAgenda()
        {
            cabeza = null;
        }

        // Inserta un nuevo contacto al FINAL de la lista.
        public void AgregarContacto(string nombre, string telefono, string correo)
        {
            
            Contacto nuevoContacto = new Contacto(nombre, telefono, correo);

            Nodo nuevoNodo = new Nodo(nuevoContacto);
            
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevoNodo;
            }

            Console.WriteLine($"[✓] Contacto '{nombre}' agregado correctamente.\n");
        }


        // Elimina el PRIMER contacto cuyo nombre coincida (sin distinción
        public void EliminarContacto(string nombre)
        {
            
            if (cabeza == null)
            {
                Console.WriteLine("[!] La agenda está vacía. No hay contactos para eliminar.\n");
                return;
            }

            
            if (cabeza.Dato.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                cabeza = cabeza.Siguiente;  
                Console.WriteLine($"[✓] Contacto '{nombre}' eliminado correctamente.\n");
                return;
            }

            
            Nodo anterior = cabeza;
            Nodo actual = cabeza.Siguiente;

            while (actual != null)
            {
                if (actual.Dato.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    
                    anterior.Siguiente = actual.Siguiente;
                    Console.WriteLine($"[✓] Contacto '{nombre}' eliminado correctamente.\n");
                    return;
                }

                
                anterior = actual;
                actual = actual.Siguiente;
            }

            
            Console.WriteLine($"[!] Contacto '{nombre}' no encontrado en la agenda.\n");
        }


        // Recorre la lista de inicio a fin e imprime cada contacto.
        public void MostrarContactos()
        {
            
            if (cabeza == null)
            {
                Console.WriteLine("[!] La agenda está vacía.\n");
                return;
            }


            Console.WriteLine("AGENDA DE CONTACTOS\n");


            Nodo actual = cabeza;
            int contador = 1;

            while (actual != null)
            {
                Console.WriteLine($"\n--- Contacto #{contador} ---");
                Console.WriteLine(actual.Dato.ToString());  
                contador++;
                actual = actual.Siguiente; 
            }

            Console.WriteLine("\n========================================\n");
        }
    }
}
