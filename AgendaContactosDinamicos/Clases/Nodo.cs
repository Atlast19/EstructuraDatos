

namespace AgendaContactosDinamicos.Clases
{
    public class Nodo
    {
        public Contacto Dato { get; set; }   // Información almacenada
        public Nodo Siguiente { get; set; }   // Referencia al próximo nodo

        public Nodo(Contacto contacto)
        {
            Dato = contacto;
            Siguiente = null;        // Nuevo nodo siempre inicia sin sucesor
        }
    }
}
