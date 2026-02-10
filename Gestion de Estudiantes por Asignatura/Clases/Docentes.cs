

using Gestion_de_Estudiantes_por_Asignatura.Interface;
using Gestion_de_Estudiantes_por_Asignatura.OperationResult;

namespace Gestion_de_Estudiantes_por_Asignatura.Clases
{
    public class Docentes: IFuncionalidades
    {
        public string[,] AsignaturasEstudiantes { get; set; }
        public double[,] ListCalificaciones { get; set; }
        public Docentes()
        {
            
        }
        public Docentes( string[,] asignaturasestudiantes, double[,] listcalificaciones)
        {
            this.AsignaturasEstudiantes = asignaturasestudiantes;
            this.ListCalificaciones = listcalificaciones;
        }

        public async Task<OperationResult<Docentes>> AgregarEstudiantes(int materias, int estudiantes)
        {
            OperationResult<Docentes> result = new OperationResult<Docentes>();

            try
            {
                AsignaturasEstudiantes = new string[materias, estudiantes];
                string[] asignatura = new string[estudiantes];

                Console.WriteLine("A solicitado ingresar un estudiante: ");
                Console.WriteLine("Ingrese a los estudiantes de cada materia: ");
                Console.WriteLine("");
                
                for (int i = 0; i < materias; i++) 
                {
                    Console.WriteLine("Nombre de la Asignatura");
                    asignatura[i] = Console.ReadLine();
                    
                    for (int j = 0; j < estudiantes; j++) 
                    {
                        Console.WriteLine($"Estudiantes de la materia de {asignatura[i]}: ");
                        AsignaturasEstudiantes[i, j] = Console.ReadLine();
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Estudiantes agregados correctamente a su asignatura correspondiente");

                return result = OperationResult<Docentes>.Success("Estudiasntes agregados correctamente");
            }
            catch (Exception e) 
            {
                return result = OperationResult<Docentes>.Failure("Error agregando a los estudiantes");
            }
        }

        public async Task<OperationResult<Docentes>> AgregarCalificaciones(int Practicas, int periodos)
        {
            OperationResult<Docentes> result = new OperationResult<Docentes>();
            try
            {
                ListCalificaciones = new double[Practicas, periodos];
                Console.WriteLine("Has solicitado agregar las calificaciones");

                Console.WriteLine("Ingrese la calificacion que obtuvo el estudiante en los periodos");

                for (int i = 0; i < Practicas; i++) 
                {
                    for (int j = 0; j < periodos; j++) 
                    {
                        Console.WriteLine($"Ingrese las calificacion que obtuvo en el periodo #{j + 1}, de la practica #{i + 1}");
                        ListCalificaciones[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Calificacion agregada correctamente");

                return result = OperationResult<Docentes>.Success("Calificaciones agregadas correctamente");
            }
            catch (Exception e)
            {
                return result = OperationResult<Docentes>.Failure("Error agregando las calificaciones");
            }
        }

        public async Task<OperationResult<Docentes>> MostrarCalificaciones()
        {
            try
            {
                if (ListCalificaciones == null)
                    return OperationResult<Docentes>.Failure("No hay calificaciones registradas");

                Console.WriteLine("");
                Console.WriteLine("--- Listado de Calificaciones ---");

                for (int i = 0; i < ListCalificaciones.GetLength(0); i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Grupo/Practica #{i + 1}:");

                    for (int j = 0; j < ListCalificaciones.GetLength(1); j++)
                    {
                        Console.WriteLine($"Periodo #{j + 1}: {ListCalificaciones[i, j]}");
                    }
                }

                return OperationResult<Docentes>.Success("Calificaciones mostradas correctamente");
            }
            catch
            {
                return OperationResult<Docentes>.Failure("Error mostrando calificaciones");
            }
        }

        public async Task<OperationResult<Docentes>> CalcularAprobados()
        {
            OperationResult<Docentes> result = new OperationResult<Docentes>();
            try
            {
                if (ListCalificaciones == null)
                    return result = OperationResult<Docentes>.Failure("No hay calificaciones registradas");

                int aprobados = 0;
                int total = 0;

                for (int i = 0; i < ListCalificaciones.GetLength(0); i++)
                {
                    for (int j = 0; j < ListCalificaciones.GetLength(1); j++)
                    {
                        total++;

                        if (ListCalificaciones[i, j] >= 70)
                            aprobados++;
                    }
                }

                double porcentaje = (double)aprobados / total * 100;

                Console.WriteLine("");
                Console.WriteLine($"Porcentaje de aprobados: {porcentaje:F2}%");

                return result = OperationResult<Docentes>.Success("Porcentaje calculado correctamente");
            }
            catch
            {
                return result = OperationResult<Docentes>.Failure("Error calculando porcentaje");
            }
        }
    }
}
