using System.Buffers.Binary;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace problemSolving
{

    internal class Program
    {



        public class Solution
        {
            public int sumOfDigits(int n)
            {
                return n * (n + 1) / 2;
            }

            public int PivotInteger(int n)
            {
                int y = sumOfDigits(n);
                double result = Math.Sqrt(y);
                if(result == (int)result)
                {
                    return (int)result;
                }
                else
                {
                    return -1;
                }
            }
        }

        static void Main(string[] args)
        {

            int[] arr = [1, 2, 4];
            Solution s = new Solution();

            Console.WriteLine(s.PivotInteger(4));









        }
    }
}
