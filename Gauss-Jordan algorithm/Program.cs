using System.Numerics;

namespace Gauss_Jordan_algorithm
{

   
    internal class Program
    {

        public static void InitialisationMatrix()
        { 
            int x = 0;
        }

        public static void GausSolving(double[][] matrix)
        {
            MatrixDivide(matrix, 0, 0);
        }

        public static void MatrixDivide(double[][] matrix, int row, int number)
        {
            double temp = matrix[row][number];
            for (int i = 0; i < matrix.Length + 1; i++)
            {
                matrix[row][i] = matrix[row][i] / temp;
            }
        }


        public static void ShowMatrix(double[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length + 1; j++)
                {
                    Console.Write(matrix[i][j] + "---");
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            double[][] matrix =
            [
                [4, 2, 3, 5],
                [2, 6, 3, 4],
                [3, 8, 8, 7]

            ];

            MatrixDivide(matrix, 0, 0);

            ShowMatrix(matrix);
            Console.ReadLine();
        }
    }
}
