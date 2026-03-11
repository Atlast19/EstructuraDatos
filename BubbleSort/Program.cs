using BubbleSort.Clases;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca;

            List<Biblioteca> bibliotecas = new List<Biblioteca>();

            Console.WriteLine("Ingrese la cantidad de libros");
            int Cantidad = int.Parse(Console.ReadLine());


            for (int i = 0; i < Cantidad; i++) 
            {
                biblioteca = new Biblioteca();

                biblioteca.Id = i;
                
                Console.Write("Ingrese el titulo de la obra: ");
                biblioteca.Titulo = Console.ReadLine();

                Console.Write("Ingrese el nombre del autor de la obra: ");
                biblioteca.Autor = Console.ReadLine();
                Console.WriteLine("");

                bibliotecas.Add(biblioteca);
            }

            BubbleSotService.BubbleSotr(bibliotecas);

            Console.WriteLine("==========================================");
            foreach (var b in bibliotecas) 
            {
                Console.WriteLine($"{b.Id}: Titulo: {b.Titulo}: Autor: {b.Autor}");
            }
            Console.WriteLine("==========================================");



        }
    }
}
