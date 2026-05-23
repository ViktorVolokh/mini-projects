using System.Numerics;

namespace Gauss_Jordan_algorithm
{

   
    internal class Program
    {

        public static void InitialisationMatrix()
        { 
            int x = 0;
        }

        public static void GaussSolving(double[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                MatrixDivide(matrix, i, i);
                if (i != matrix.Length - 1)
                {
                    for (int j = i + 1; j < matrix.Length; j++)
                    {
                        MatrixSubstract(matrix, j, i, i);
                    }
                }
            }
            for (int i = matrix.Length - 1; i > -1; i--)
            {

                for (int j = matrix.Length - 1; j > -1; j--)
                {
                    if (i != j)
                    {
                        MatrixSubstract(matrix, j, i, i);
                    }
                }      
            }
        }

        public static void MatrixDivide(double[][] matrix, int row, int number)
        {
            double temp = matrix[row][number];
            for (int i = 0; i < matrix.Length + 1; i++)
            {
                matrix[row][i] = matrix[row][i] / temp;
            }
        }

        public static void MatrixSubstract(double[][] matrix, int mainRow, int secondaryRow, int target)
        {
            double coefficient = matrix[mainRow][target];
            for (int i = 0; i < matrix.Length + 1; i++)
            {
                matrix[mainRow][i] = matrix[mainRow][i] - coefficient * matrix[secondaryRow][i];
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
    [1,  1,  1,  1,  1,  15], // 1 + 2 + 3 + 4 + 5 = 15
    [2, -1,  3,  1, -1,   8], // 2(1) - 2 + 3(3) + 4 - 5 = 9  (ТУТ КІНЦЕВА 9!)
    [1,  3, -1,  2,  2,  22], // 1 + 3(2) - 3 + 2(4) + 2(5) = 22
    [3,  1,  2, -1,  1,  12], // 3(1) + 2 + 2(3) - 4 + 5 = 12
    [1,  2,  1, -3,  1,  1]
];

            GaussSolving(matrix);

            ShowMatrix(matrix);
            Console.ReadLine();
        }
    }
}
