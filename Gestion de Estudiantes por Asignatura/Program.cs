using Gestion_de_Estudiantes_por_Asignatura.Clases;

namespace Gestion_de_Estudiantes_por_Asignatura
{
    public class Program
    {
        static void Main(string[] args)
        {
            Docentes docente = new Docentes();
            bool salir = false;

            while (!salir) 
            {
                Console.WriteLine("Sistema de los docentes para la gestion de los estudiantes");
                Console.WriteLine("Opciones del sistema");

                Console.WriteLine("");
                Console.WriteLine("#1: Agregar las asignaturas impartidas y a los estudiantes de cada asignatura");
                Console.WriteLine("#2: Registrar las calificaciones de cada estudiante en cada periodo");
                Console.WriteLine("#3: Mostrar el listado de las calificaciones");
                Console.WriteLine("#4: Mostrar el porcentaje de los estudiantes aprobados");
                Console.WriteLine("");

                Console.Write("Ingrese su opcion por pantalla: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:
                        Console.WriteLine("Se requiere agregar la asignatura y la cantidad de estudiantes por asignatura");

                        Console.Write("Cantudad de asignaturas: ");
                        int grupo = int.Parse(Console.ReadLine());

                        Console.Write("Cantidad de estudiantes: ");
                        int estudiante = int.Parse(Console.ReadLine());

                        docente.AgregarEstudiantes(grupo, estudiante);
                        break;

                    case 2:
                        Console.WriteLine("Agregar Calificaciones de los estudiantes");

                        Console.Write("Ingresar la antidad de practicas: ");
                        int practicas = int.Parse(Console.ReadLine());

                        Console.Write("Ingresar los periodos de evaluacion: ");
                        int periodos = int.Parse(Console.ReadLine());

                        docente.AgregarCalificaciones(practicas, periodos);
                        break;

                    case 3:
                        docente.MostrarCalificaciones();
                        break;

                    case 4:
                        docente.CalcularAprobados();
                        break;

                    default:
                        Console.WriteLine("no se ha ingresado una opcion valida");
                        break;
                }
            }
        }
    }
}
