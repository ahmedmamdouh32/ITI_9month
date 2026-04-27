using SOLID.SOLID_Implement_2._2_3_LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Square parent = new Square();
            
            parent.Width = 100;
            parent.Height = 100;


            Console.WriteLine(parent.Area());

        }
    }
}
