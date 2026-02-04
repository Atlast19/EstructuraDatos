namespace Comprobación_de_suma_de_dos_números
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;

            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Ingrese el tercer numero: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            if ((num1 + num2 == num3) || (num1 + num3 == num2) || (num2 + num3 == num1))
            {
                Console.WriteLine();
                Console.WriteLine("Iguales");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Distintas");
            }
        }
    }
}
