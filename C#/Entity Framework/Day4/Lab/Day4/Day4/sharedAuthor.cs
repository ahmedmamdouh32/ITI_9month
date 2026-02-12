using Day4.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    static public class sharedAuthor
    {
        static sharedAuthor()
        {
            Author = new Author();
        }
        public static Author Author{ set; get; }
    }
}
