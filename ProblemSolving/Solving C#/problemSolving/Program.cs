using System.Buffers.Binary;
using System.Text;

namespace problemSolving
{

    internal class Program
    {
        public class Solution
        {

            //helper function:
            public string reverseString(string s)
            {
                StringBuilder result= new StringBuilder(s);
                for (int i = 0; i < s.Length / 2; i++)
                {
                    result[i]= s[s.Length - 1 - i];
                    result[s.Length - 1 - i] = s[i];
                }
                return result.ToString(); 
            }
            public string AddBinary(string a, string b)
            {
                int a_bit = 0, b_bit = 0,Sum = 0;
                int carry = 0;
                StringBuilder answer = new StringBuilder();
                a = reverseString(a);
                b = reverseString(b);
                int maxLength = Math.Max(a.Length, b.Length);
                for(int i = 0; i < maxLength; i++)
                {
                    if(i < a.Length)a_bit = a[i]-'0';
                    else a_bit = 0;

                    if (i < b.Length) b_bit = b[i]-'0';
                    else b_bit = 0;

                    Sum = a_bit ^ b_bit ^ carry; //equation of Sum in full adder(3-bits)
                    carry = a_bit & b_bit | b_bit&carry | a_bit&carry;//equation of carry in full adder(3-bits)
                    answer.Append(Sum);
                }
                if (carry == 1)
                {
                    answer.Append('1');
                }
                return reverseString(answer.ToString());
            }
        }

        static void Main(string[] args)
        {

            Solution s = new Solution();


            string a = "1", b = "10";

            string result = s.AddBinary(a, b);
            Console.WriteLine(result);







        }
    }
}
