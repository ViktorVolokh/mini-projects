namespace Permutatio;

class Program
{
    public static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
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
    }
}
