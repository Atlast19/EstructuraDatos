namespace Temperaturas
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Temperaturas 
             * 
             * Se requiere craear un programa que almacene en un arreglo las temperaturas de una ciudad durante 10 días y determina:
             * 
             * Temperatura más alta y más baja
             * Promedio de temperaturas
             * Cuántos días estuvieron por encima de 30°C*/

            int DIAS = 10;
            double[] temperaturas = new double[DIAS];

            double suma = 0;
            double max, min;
            int diasMayor30 = 0;

            for (int i = 0; i < DIAS; i++)
            {
                Console.Write($"Ingrese la temperatura del día {i + 1}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());
                suma += temperaturas[i];

                if (temperaturas[i] > 30)
                {
                    diasMayor30++;
                }
            }

            max = temperaturas[0];
            min = temperaturas[0];

            for (int i = 1; i < DIAS; i++)
            {
                if (temperaturas[i] > max)
                    max = temperaturas[i];

                if (temperaturas[i] < min)
                    min = temperaturas[i];
            }

            double promedio = suma / DIAS;

            Console.WriteLine("RESULTADOS:");
            Console.WriteLine($"Temperatura más alta: {max} °C");
            Console.WriteLine($"Temperatura más baja: {min} °C");
            Console.WriteLine($"Promedio de temperaturas: {promedio} °C");
            Console.WriteLine($"Días con temperatura mayor a 30°C: {diasMayor30}");

        }
    }
}
