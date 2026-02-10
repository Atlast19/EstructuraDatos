

using Gestion_de_Estudiantes_por_Asignatura.Clases;
using Gestion_de_Estudiantes_por_Asignatura.OperationResult;

namespace Gestion_de_Estudiantes_por_Asignatura.Interface
{
    public interface IFuncionalidades
    {
        Task<OperationResult<Docentes>> AgregarEstudiantes(int materias, int estudiantes);

        Task<OperationResult<Docentes>> AgregarCalificaciones(int Practicas, int periodos);

        Task<OperationResult<Docentes>> MostrarCalificaciones();

        Task<OperationResult<Docentes>> CalcularAprobados();
    }
}
