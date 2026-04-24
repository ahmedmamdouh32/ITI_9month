using SOLID.SOLID_Case.Case_2_OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case_Answer.Case_Answer_2_OCP
{
    #region Bad Code
    public class Drawing
    {
        //public string DrawShape(string shape)
        //{
        //    string result = string.Empty;
        //    if (shape == "Circle")
        //    {
        //        result="Drawing a Circle";
        //    }
        //    else if (shape == "Square")
        //    {
        //        result ="Drawing a Square";
        //    }

        //    return result;
        //}



        public string DrawShape(Shapes shape)
        {
            return shape.Drawing();
        }
    }

    #endregion
}
