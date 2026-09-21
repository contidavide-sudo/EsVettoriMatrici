namespace EsVettoriMatrici
{
    internal class Program
    {
        //Es 4
        static int[,] Inserimento( int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r,c]= int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            return matrix;
        }

        static int[] Somma( int[,] matrix )
        {
            int[] vet = new int[matrix.GetLength(0)];
            int somma = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    somma = somma + matrix[r,c];
                }

                vet[r] = somma;
                somma = 0;

                Console.WriteLine();
            }

            return vet;
        }

        static void Main(string[] args)
        {
            //Es 4
            int[,] mat = new int[3,3];

            mat = Inserimento(mat);

            for (int r = 0; r < mat.GetLength(0); r++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("[" + mat[r,c] + "]");
                }
                Console.WriteLine();
            }

            int[] vett = Somma(mat);

            for (int i = 0; i < vett.Length; i++)
            {
                Console.Write("[" + vett[i] + "]");
            }

        }
    }
}
