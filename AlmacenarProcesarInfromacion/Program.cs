namespace AlmacenarProcesarInfromacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese numero de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            Console.WriteLine();
            Console.WriteLine("Ingrese los valores de la matriz:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Valor [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matriz ingresada:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
            int max = matriz[0, 0];
            int min = matriz[0, 0];
            int filaMax = 0, colMax = 0;
            int filaMin = 0, colMin = 0;

            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] > max)
                    {
                        max = matriz[i, j];
                        filaMax = i;
                        colMax = j;
                    }

                    if (matriz[i, j] < min)
                    {
                        min = matriz[i, j];
                        filaMin = i;
                        colMin = j;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Resultado");
            Console.WriteLine($"Valor mayor: {max} en posicion [{filaMax},{colMax}]");
            Console.WriteLine($"Valor menor: {min} en posicion [{filaMin},{colMin}]");
        }
    }
}
