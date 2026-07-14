import java.util.Scanner;
public class Determinant
{
    // det3x3 = a * det2x2 - b * det2x2 + c * det2x2 - d * det2x2
    public static int findDeterminant(int array[][])
    {
        int determinant = 0;
        if(array.length > 2)
        {
            int[] temp = new int[array.length];
            for (int i = 0; i < array.length; i++)
            {
                temp[i] = array[i][0]; //switch to 0, n
            }
            for (int n = 0; n < array.length; n++)
            {
                determinant += (int) Math.pow(-1, n + 2) * temp[n] * findDeterminant(minorMatrix(array, 0, n)); 
            }
            return determinant;
        }
        if (array.length == 2)
        {
            determinant = determinantTwoXTwo(array);
            return determinant;
        }
         return determinant;
    }
    
    public static int[][] minorMatrix(int array[][], int row, int column)
    {
        int[][] newArray = new int[array.length - 1][array.length - 1];
        for(int i = 0; i < array.length - 1; i++)
        {
            for(int k = 0; k < array.length - 1; k++)
            {
                if (i < row && k < column)
                {
                    newArray[i][k] = array[i][k];
                }
                else if (i < row && k >= column)
                {
                    newArray[i][k] = array[i][k+1];
                }
                else if (i >= row && k < column)
                {
                    newArray[i][k] = array[i+1][k];
                }
                else if (i >= row && k >= column)
                {
                    newArray[i][k] = array[i+1][k+1];
                }
                
            }
        }
        return newArray;
    }
    
    public static void feelMatrix(int[][] array)
    {
        for(int i = 0; i < array.length; i++)
        {
            for(int k = 0; k < array.length; k++)
            {
                Scanner localscanner = new Scanner(System.in);
                array[i][k] = localscanner.nextInt();
            }
        }
    }
    
    public static void showMatrix(int[][] array)
    {
        for(int i = 0; i < array.length; i++)
        {
            for(int k = 0; k < array.length; k++)
            {
                System.out.print(array[i][k] + " ");
            }
            System.out.println();
        }
    }
    
    public static int determinantTwoXTwo(int[][] array)
    {
       return array[0][0]*array[1][1] - array[0][1]*array[1][0]; 
    }
     
   public static void main(String[] args)
   {
       //Scanner sc = new Scanner(System.in);
       //int n = sc.nextInt();
       //int[][] array = new int[n][n];
       int[][] array = {
         {1, 2, 3},
         {4, 5, 6},
         {7, 8, 9}
        };

       showMatrix(array);
       System.out.println(determinantTwoXTwo(array));
   }
}
