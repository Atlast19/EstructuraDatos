

namespace AgendaContactosDinamicos.Clases
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        public Contacto(string nombre, string telefono, string correo)
        {
            Nombre = nombre;
            Telefono = telefono;
            CorreoElectronico = correo;
        }

        // Devuelve una representación textual del contacto
        public override string ToString()
        {
            return $"  Nombre  : {Nombre}\n" +
                   $"  Teléfono: {Telefono}\n" +
                   $"  Correo  : {CorreoElectronico}";
        }
    }
}
