namespace cálculo_del_promedio_de_un_conjunto_de_valores_numéricos
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> agregar = new List<int>();

            Console.Write("Ingresa numeros hasta detenerte en 0");

            while (true)
            {
                Console.WriteLine();
                Console.Write("valor: ");
                int numeros = int.Parse(Console.ReadLine());

                if (numeros == 0)
                    break;

                agregar.Add(numeros);
                
                Console.Write("Numeros ingresados: ");

                foreach (int item in agregar) 
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine();
            double promedio = agregar.Average();
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
