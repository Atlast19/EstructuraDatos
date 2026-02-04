namespace ArregloInverso
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];


            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Ingrese el numero {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Arreglo en orden inverso:");

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
