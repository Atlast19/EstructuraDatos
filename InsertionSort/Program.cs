namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tiempos = { 58, 54, 60, 52, 57, 56, 59 };

            InsertionSort(tiempos);
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;

                Console.Write($"Paso: {i}: ");
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
