using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Implement_2._2_3_LSP
{
    #region Bad Code


    public abstract class Shape
    {
        public abstract int Area();
    }
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int Area()
        {
            throw new NotImplementedException();
        }
    }
    public class Square : Shape
    {
        public int sideLength{ set;get; }
        public override int Area()
        {
            return sideLength * sideLength;
        }
        //public new int Width
        //{
        //    get { return base.Width; }
        //    set
        //    {
        //        base.Width = value;
        //        base.Height = value;
        //    }
        //}
        //public new int Height
        //{
        //    get { return base.Height; }
        //    set
        //    {
        //        base.Height = value;
        //        base.Width = value;
        //    }
        //}
    }

    #endregion
}
