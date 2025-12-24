using System.Collections.Specialized;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int maxValue = 10000;
            int onesCounter = 0;
            for (int i = 0;i<maxValue; i++)
            {
                onesCounter += i.ToString().Count('1');
            }

            Console.WriteLine(onesCounter);
            Console.WriteLine(8* Math.Pow(10, 7));
        }
    }
}
