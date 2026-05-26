using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Gauss_Jordan_algorithm
{

    internal class Program
    {
        
        public static void MatrixInitialisation(double[][] matrix)
        {
            Console.WriteLine("write your matrix:");
            for (int i = 0; i < matrix.Length ; i++)
            {
                for (int j = 0; j < matrix.Length + 1; j++)
                {
                    matrix[i][j] = Convert.ToDouble(Console.ReadLine());

                }
                Console.WriteLine($"the row {i+1} is filled");
            }
        }

        /// <summary>
        /// Checks how many solution the matrix have.
        /// </summary>
        /// <param name="matrix">The matrix we are working on</param>
        /// <returns></returns>
        public static int MatrixCheckingBefore(double[][] matrix)
        {
            
            for (int i = 0; i < matrix.Length ; i++)
            {
                bool temp;
                int counter = 0;
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[i][j] == 0)
                        counter++;
                    
                }
                if (counter == matrix.Length)
                    if (matrix[i][matrix.Length] == 0)
                        return -1;
                    else
                        return 0;
                
            }
            return 1;
        }


        public static void GaussSolving(double[][] matrix)
        {
            int temp = MatrixCheckingBefore(matrix);
            if (temp == 1)
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
            else if(temp == 0)
                Console.WriteLine("no solutions");
            else
                Console.WriteLine("infinity solutions");
        }
        /// <summary>
        /// Normalizes a specific row by dividing all its elements by the value at the specified diagonal position.
        /// This makes the diagonal element equal to 1.
        /// </summary>
        /// <param name="matrix">The augmented matrix being solved.</param>
        /// <param name="row">The index of the row to be normalized.</param>
        /// <param name="number">The index of the column containing the divisor (diagonal element).</param>
        public static void MatrixDivide(double[][] matrix, int row, int number)
        {
            double temp = matrix[row][number];
            for (int i = 0; i < matrix.Length + 1; i++)
            {
                matrix[row][i] = matrix[row][i] / temp;
            }
        }

        /// <summary>
        /// Subtracts one row from another to make a zero in the target column.
        /// </summary>
        /// <param name="matrix">The matrix we are working on.</param>
        /// <param name="mainRow">The row we are changing.</param>
        /// <param name="secondaryRow">The row we use to subtract.</param>
        /// <param name="target">The index of the column to set to zero.</param>
        public static void MatrixSubstract(double[][] matrix, int mainRow, int secondaryRow, int target)
        {
            double coefficient = matrix[mainRow][target];
            for (int i = 0; i < matrix.Length + 1; i++)
            {
                matrix[mainRow][i] = matrix[mainRow][i] - coefficient * matrix[secondaryRow][i];
            }
        }
        /// <summary>
        /// displays 2-dimensional matrix on the console.
        /// </summary>
        /// <param name="matrix">The matrix we are working on.</param>
        public static void ShowMatrix(double[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length + 1; j++)
                {
                    Console.Write(matrix[i][j] + "|");
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("How many rows does your matrix cointain?");
            int row = Convert.ToInt32(Console.ReadLine()); // using convert because this is project for me and not for idiots

            double[][] matrix = new double[row][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new double[row + 1];
            }
            MatrixInitialisation(matrix);
            GaussSolving(matrix);
            ShowMatrix(matrix);

            Console.ReadLine();
        }
    }
}
