namespace SelectionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 250, 120, 75, 300, 100, 180, 90, 220 };

            SelectionSort(numeros);

            Console.WriteLine("");
            Console.WriteLine("Arreglo ordenado:");

            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("");
        }

        public static void SelectionSort(int[] arreglo) 
        {
            int n = arreglo.Length;


            for (int i = 0; i < n - 1; i++) 
            {
                int MinIndex = i;

                for (int j = i + 1; j < n; j++) 
                {
                    if (arreglo[j] < arreglo[MinIndex]) 
                    {
                        MinIndex = j;
                    }
                }

                Console.WriteLine($"Iteración: {i}: índice mínimo: {MinIndex}:  valor: {arreglo[MinIndex]}");

                int temp = arreglo[MinIndex];
                arreglo[MinIndex] = arreglo[i];
                arreglo[i] = temp;
            }

        }
    }
}
