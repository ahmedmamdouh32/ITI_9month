using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case.Case_2_OCP
{
    internal class Circle : Shapes
    {
        public override string Drawing()
        {
            return "drawing circle";
        }
    }
}
