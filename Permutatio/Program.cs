
namespace Permutatio;
class Program
{
    public static double GeneraliseExperiment(int[] array)
    {
        
        int[] data = new int[array.Length * 10/* for more accuracy use more multiplicators such as 1000000*/];
        for (int i = 0; i < array.Length * 10 /* for more accuracy use more multiplicators such as 1000000*/; i++)
        {
            ShuffleTwoElements(array);
            data[i] = CountInversions(array);
        }
        return data.Average();
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
        Console.WriteLine(GeneraliseExperiment(permutation));
    }
}
