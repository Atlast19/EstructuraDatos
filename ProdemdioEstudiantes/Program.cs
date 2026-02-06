

namespace ProdemdioEstudiantes
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int estudiantes = 4;
            int asignaturas = 3;

            double[,] notas = new double[estudiantes, asignaturas];

            
            for (int i = 0; i < estudiantes; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Estudiante {i + 1}:");

                for (int j = 0; j < asignaturas; j++)
                {
                    Console.Write($"Ingrese nota de asignatura {j + 1}: ");
                    notas[i, j] = double.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine();
            Console.WriteLine("Promedio de cada estudiante:");

            for (int i = 0; i < estudiantes; i++)
            {
                double suma = 0;

                for (int j = 0; j < asignaturas; j++)
                {
                    suma += notas[i, j];
                }

                double promedio = suma / asignaturas;
                Console.WriteLine($"Estudiante {i + 1}: {promedio}");
            }


            Console.WriteLine();
            Console.WriteLine("Promedio de cada asignatura:");

            for (int j = 0; j < asignaturas; j++)
            {
                double suma = 0;

                for (int i = 0; i < estudiantes; i++)
                {
                    suma += notas[i, j];
                }

                double promedio = suma / estudiantes;
                Console.WriteLine($"Asignatura {j + 1}: {promedio}");
            }
        }
    }
}
