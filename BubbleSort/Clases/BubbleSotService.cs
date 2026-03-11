

namespace BubbleSort.Clases
{
    public static class BubbleSotService
    {
        public static void BubbleSotr(List<Biblioteca> biblioteca) 
        {
            int n = biblioteca.Count;

            for (int i = 0; i < n - 1; i++) 
            {
                for (int j = 0; j < n - i - 1; j++) 
                {
                    if (Comparation(biblioteca[j], 
                        biblioteca[j + 1]) > 0) 
                    {
                        var comp = biblioteca[j];
                        biblioteca[j] = biblioteca[j + 1];
                        biblioteca[j + 1] = comp;
                    }
                }
            }
        }
        static int Comparation(Biblioteca b1, Biblioteca b2) 
        {
            int result = 0;

            if (b2.Titulo != b1.Titulo) 
            {
                result = b1.Titulo.CompareTo(b2.Titulo);
            }
            return result;
        }
    }
}
