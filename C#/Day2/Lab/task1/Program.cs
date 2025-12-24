using System.Diagnostics.Metrics;
using System.Runtime.ExceptionServices;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxLength = 0;
            int[] arr = {7,0,0,0,5,6,7,5,0,7,5,3};
           
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = arr.Length - 1; j > maxLength; j--)
                {
                    if (arr[i] == arr[j])

                    {
                        Console.WriteLine($"arr[i] = {arr[i]} --> i = {i}");
                        Console.WriteLine($"arr[j] = {arr[j]} --> j = {j}");
                        if (maxLength < (j - i)) maxLength = j - i - 1;
                        Console.WriteLine($"Max Length = {maxLength}");
                        Console.WriteLine("-----------");
                        break;
                    }
                }
            }
            Console.WriteLine(maxLength);
        }
    }
}
