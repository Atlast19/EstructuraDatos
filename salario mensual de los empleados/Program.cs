namespace salario_mensual_de_los_empleados
{
    public class Program
    {
        static void Main(string[] args)
        {
            double SalarioSemanal;
            double SalarioMensual;

            Console.Write("Ingrese la tarifa que gana por hora: ");
            double TarifaBase = double.Parse(Console.ReadLine());

            Console.Write("Ingrese las Horas que trabajo en la semana: ");
            int HorasTrabajadas = int.Parse(Console.ReadLine());

            if (HorasTrabajadas <= 40)
            {
                SalarioSemanal = HorasTrabajadas * TarifaBase;
            }
            else
            {
                int HoraExtra = HorasTrabajadas - 40;
                double tarifaExtra = TarifaBase * 1.5;

                SalarioSemanal = (40 * HorasTrabajadas) + (HoraExtra * tarifaExtra);
            }

            SalarioMensual = SalarioSemanal * 4;


            Console.WriteLine();
            Console.WriteLine($"El salario semanal es de: {SalarioSemanal}$");
            Console.WriteLine();
            Console.WriteLine($"El salario mensual es de: {SalarioMensual}$");
        }

    }
}
  