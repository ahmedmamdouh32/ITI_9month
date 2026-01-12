namespace Day7PII
{
    class test
    {
        public int id { get; set; }
         test(int id=0)
        {
            this.id = id;
        }
        static test t;
        public static test gettest()
        {
            if (t == null)
            {
                t = new test();
                return t;
            }
            else
                return t;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            test t1 = test.gettest();
            test t2 = test.gettest();
            Console.WriteLine(t1.GetHashCode());
            Console.WriteLine(t2.GetHashCode());

        }
    }
}
