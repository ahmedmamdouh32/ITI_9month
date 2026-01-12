using System.Threading.Tasks.Sources;

namespace leetcode
{
    internal class Program
    {

        public class c1{

           public string upper(string s)
            {
                return s.ToLower();
            }
        
        }

        static void Main(string[] args)
        {
            c1 c1 = new c1();

            Console.WriteLine(c1.upper("Hello"));
            Console.WriteLine((int)'A');


        }

    }
}
