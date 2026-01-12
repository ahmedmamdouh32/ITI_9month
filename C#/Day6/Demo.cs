namespace Day6
{
    enum gender
    {
        male, female
    }
    enum orderstatus:byte
    {
        pending=10 , shiped ,delivered=100 ,returned
    }
    [Flags]
    enum prev:byte
    {
        admin=1, instructor=2, student=4,supervisor=8 ,manager=16
    }
    class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        //public override bool Equals(object obj)
        //{
        //    //as 
        //    employee em = obj as employee;
        //    if (em == null) return false;
        //    else
        //        return (id == em.id);

        //    //is
        //    //if (obj is employee em)
        //    //{
        //    //   // employee em = (employee)obj;
        //    //    return (id == em.id);
        //    //}
        //    //else
        //    //    return false;
        //}
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  checked , unchecked ,tryparse ,is,as
            //checked
            //{
            //    //int x = int.MaxValue;
            //    //x = x + 10;
            //    uint x = uint.MaxValue;
            //    //  x = checked(x + 10);
            //    unchecked
            //    {
            //        x = x + 10;
            //    }
            //    // Console.WriteLine($"int min value={uint.MinValue}");
            //    Console.WriteLine($"x={x}");
            //}

            //tryparse

            //   Console.WriteLine("enter number");
            //   //  int x= int.Parse(Console.ReadLine());
            //   //int x;
            // bool status=  int.TryParse(Console.ReadLine(), out int x);
            //   Console.WriteLine($"status={status} ,x={x}");
            //  // x++;
            ////   Console.WriteLine(x);
            ///
            //int x;
            //bool status = false;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("enter number");
            //    status = int.TryParse(Console.ReadLine(), out x);
            //}
            //while (status == false);
            //is
            //object obj = 123;
            //if (obj is int x)//pattern match
            //{
            //    Console.WriteLine(x);
            //    //int x = (int)obj;
            //}

            //int x = 5;

            //if(x is object)
            //{

            //}

            //employee em = new employee() { id = 4 };
            //employee em2 = new employee() { id = 4 };
            //string txt = "123";
            //if (em.Equals(em2))
            //{
            //    Console.WriteLine("equal");
            //}
            //else
            //{
            //    Console.WriteLine("notequal");
            //}


            //as 

            //object obj = new employee() { id = 12 };
            //obj = 123;
            //employee em = obj as employee;
            #endregion
            #region null condational operator  ,null coalscing operator ,null coalsing assign operator ,ternary operator ,null operator
            //?   , ?. ,?[] ,?? ,??= , ?:

            //  //? nullable datatype
            // Nullable<int> x = null;
            ////  int x = null;
            //  int? x = null;

            //nullable ref datatype 

            //?. ,?[] nullcondational operator 

            //int[] arr = { 1,2,3};
            ////   if(arr != null)
            //// Console.WriteLine(arr.Length);
            //int? x = arr?.Length;
            //Console.WriteLine(x);

            //int[] arr = { 3,4,5};
            //Console.WriteLine(arr?[0]);

            //??

            // string txt = null;
            //string txt2;
            //if (txt != null)
            //{
            //    txt2 = txt;
            //}
            //else
            //    txt2 = "hi";

            //string txt2 = txt ?? "hi";

            //??=
            //string txt = null;
            //if (txt == null)
            //    txt = "hi";


            //txt ??= "hi";


            //int x = 5;
            ////int y;
            ////if (x > 5)
            ////    y = x;
            ////else
            ////    y = 10;

            //int y = (x > 5) ? x : 10;

            #endregion

            #region  enum
            //gender g = gender.male;
            //g = gender.female;
            //Console.WriteLine(g);
            //int x = 2;
            //orderstatus b = orderstatus.pending;

            // orderstatus o = orderstatus.returned;
            // orderstatus o = (orderstatus)107;
            //  Console.WriteLine(o);

            //   orderstatus o1 = Enum.Parse<orderstatus>(Console.ReadLine());
            //  orderstatus o2;
           // bool status=   Enum.TryParse<orderstatus>(Console.ReadLine(), out o2);
            //Console.WriteLine(o2); 
            //   Console.WriteLine(o1);
            //   //switch (o)
            //   //{
            //   //    case orderstatus.returned:
            //   //        break;

            //   //}

            //prev p = (prev)7;
            //Console.WriteLine(p);
            //prev p = prev.admin ^ prev.student ^prev.instructor;
            //Console.WriteLine(p);
            #endregion
        }
    }
}
