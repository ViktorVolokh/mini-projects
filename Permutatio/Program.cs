
namespace Permutatio;
class Program
{
    public delegate void Results(int[] array, out long allSwapVariants, out long sum);
    public static double GeneraliseExperiment(int[] array)
    {
        int inversionsNumber = CountInversions(array);
        double sum = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                SwapTwoElements(array, i, j);
                sum += CountInversions(array,  i, j, inversionsNumber);
                SwapTwoElements(array, i, j);
            }
        }

        long allSwapVariants = array.Length * (array.Length - 1) / 2;
        sum = sum / allSwapVariants;
        return sum;
    }

    public static void GeneraliseExperiment(int[] array, out long allSwapVariants, out long sum)
    {
        int inversionsNumber = CountInversions(array);
        sum = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                SwapTwoElements(array, i, j);
                sum += CountInversions(array,  i, j, inversionsNumber);
                SwapTwoElements(array, i, j);
            }
        }

        allSwapVariants = array.Length * (array.Length - 1) / 2;
    }
    public static void Output(int[] array, Results results)
    {
        results(array, out long allSwapVariants, out long sum);
        int i = 2;
        while (i < allSwapVariants || i < sum)
        {
            if (sum % i == 0 && allSwapVariants % i == 0)
            {
                sum /= i;
                allSwapVariants /= i;
                i = 1;
            }
            i++;
        }
        Console.WriteLine($"{sum} / {allSwapVariants}");
    }

    public static void SwapTwoElements(int[] array, int element1, int element2)
    {
        int temp = array[element1];
        array[element1] = array[element2];
        array[element2] = temp;
    }

    public static void ShuffleTwoElements(int[] array)
    {
        Random random = new Random();
        int num1 = random.Next(0, array.Length);
        int num2 = random.Next(0, array.Length);
        while (num1==num2)
        {
            num2 = random.Next(0, array.Length);
        }
        int temp = array[num1];
        array[num1] = array[num2];
        array[num2] = temp;
    }

    public static int CountInversions(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[i] > array[j + 1])
                {
                    count++;
                }
            }
        }
        return count;
    }

    public static int CountInversions(int[] array, int num1, int num2, int startInversionsNumber)
    {
        int count = startInversionsNumber;
        for (int i = num1; i < num2; i++)
        {
            if (array[num1] > array[i + 1])
            {
                count++;
            }
        }
        for (int i = num2-1; i > num1; i--)
        {
            if (array[i] > array[num2])
            {
                count++;
            }
        }
        SwapTwoElements(array, num1, num2);
        for (int i = num1; i < num2; i++)
        {
            if (array[num1] > array[i + 1])
            {
                count--;
            }
        }
        SwapTwoElements(array, num1, num2);
        return count;
    }

    public static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        Random random = new Random();
        //random.Shuffle(array);
    }

    public static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    static void Main(string[] args)
    {
        int n = 0;
        while (n == 0)
        {
            n = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        }
        int[] permutation = new int[n];
        FillArray(permutation);
        ShowArray(permutation);
        Console.WriteLine();
        /*Console.WriteLine(CountInversions(permutation));
        ShuffleTwoElements(permutation);
        ShowArray(permutation);
        Console.WriteLine();
        Console.WriteLine(CountInversions(permutation));*/
        Console.WriteLine("answer:");
        Output(permutation, GeneraliseExperiment);
    }
}
