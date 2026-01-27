using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Practicing
{


    public class Parent
    {
        //public Parent()
        //{
        //    Console.WriteLine("parent is here");
        //}
        public Parent()
        {
            Console.WriteLine($"parent prints height:");
        }
    }
    public class Creature:Parent
    {

        int Height;
        int Width;

        public Creature():this(12,13)
        {
            Console.WriteLine("parameter less");
        }
        public Creature(int h):this()
        {
            Console.WriteLine($"base class si here,:{h}");
        }

        public Creature(int height, int width) :this(height)
        {

            Height = height;
            Width = width;
            Console.WriteLine("last order");
        }
    }
    class Program
    {
        static void Main()
        {

            Creature c =new Creature(1,2);
        }
    }
}


