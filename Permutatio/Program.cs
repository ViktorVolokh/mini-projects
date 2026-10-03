using System.Security.Cryptography;
using System;
namespace Permutatio;
class Program
{

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

    public static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        Random random = new Random();
        random.Shuffle(array);
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
        ShuffleTwoElements(permutation);
        ShowArray(permutation);
    }
}
