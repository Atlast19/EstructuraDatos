namespace Verificar_existencia_de_un_cliente_en_registro_masivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] cedulas = new int[1000];

            
            for (int i = 0; i < cedulas.Length; i++)
            {
                cedulas[i] = 100000 + i;
            }

            int cedulaBuscada = 100500;
            bool encontrado = false;

            foreach (int cedula in cedulas)
            {
                if (cedula == cedulaBuscada)
                {
                    encontrado = true;
                    break;
                }
            }

            Console.WriteLine(encontrado ? "Cliente encontrado" : "Cliente no encontrado");
        }
    }
}
