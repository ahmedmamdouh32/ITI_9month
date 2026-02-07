using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.models
{
    internal class ComparerCaseInsensitive: IComparer<string>
    {
         public int Compare(string? x, string? y)
            {
                if(x == null)
                {
                    return -1;
                }
                else if(y == null)
                {
                    return 1;
                }

                x = x.ToLower();
                y = y.ToLower();

                for (int i=0;i<Math.Min(x.Length, y.Length); i++)
                {
                    if (x[0] > y[0]) return 1;
                    else if (x[0] < y[0]) { return -1; }
                }
                return 0;
            }
    }
}
