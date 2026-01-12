namespace Day6PII
{
    class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public static int count=0;
        public employee( string name , int age)
        {
            count++;
            this.id = count;
            this.name = name;
            this.age = age;
        }

        //public employee (int id , string name):this(id,name,0)
        //{

        //    this.id = 7;
        //}

        public override string ToString()
        {
            return $"{id}-{name}-{age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region this

            // employee em = new employee(3, "ali");
            #endregion
            #region  static
            employee em = new employee("ahmed", 22);
            //Console.WriteLine(em);
            employee em2 = new employee("ali", 22);
            Console.WriteLine(em);
            Console.WriteLine(em2);

            #endregion
        }
    }
}
