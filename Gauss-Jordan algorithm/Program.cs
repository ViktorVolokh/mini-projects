using System.Numerics;

namespace Gauss_Jordan_algorithm
{

   
    internal class Program
    {

        public static void InitialisationMatrix()
        { 
            int x = 0;
        }

        public static void MatrixSolving(double[][] matrix)
        {
            int x = 0; 
        }

        public static void MatrixDivide(double[][] matrix, int row, int number)
        {
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                matrix[row][i] = matrix[row][number];
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
            
            
        }
    }
}
