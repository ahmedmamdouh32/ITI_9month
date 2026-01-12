namespace Day8
{
    class parent
    {
        int z;
        public int x { get; set; }
        public parent()
        {
            
        }

        public parent(int z)
        {
            this.z = z;
        }
        public virtual void show()
        {
            Console.WriteLine($"x={x},z={z}");
        }
    }

    class child :parent
    {
        //  public new string x { get; set; }
     //   private new int z;
        public int y { get; set; }
     
        public child(int x , int y , int z):base(z)
        {
             this.x = x;
        
            this.y = y;
            
        }

        public  override void show()
        {
            base.show();
            Console.WriteLine($"y={y}");
        }

    }
    class subchild:child
    {
        public int a { get; set; }

        public subchild(int x , int y , int z , int a) :base(x,y,z)
        {
            this.a = a;
        }
        public new void show()
        {
            base.show();
            Console.WriteLine($"a={a}");
        }

    }
  //  class a
  //  {

  //  }

  //sealed  class test:a
  //  {

  //  }
  //  class b : testxxxxxxxxxxxx
  //  {

  //  }
    internal class Program
    {
         static void display(parent p)
        {
            p.show();
        }
        static void Main(string[] args)
        {
            //child c = new child();
            //c.x = 3;
            //Console.WriteLine(c.x);

            //child c = new child();
            //c.x = 3;
            //c.y = 4;
            //c.show();

            //child c = new child();
            //c.x = "ali";


            //parent p = new child();
            // p.show();
            //child c= new parent();

            // child c = new child(3,4,5);
            //c.show();

            // parent p = new child(3,4,5);
            //  p.show();
            //   subchild s = new subchild(1, 2, 3, 4);
            //  s.show();

             //  display(new parent(1));//parent p = new parent()
           // display(new child(1,2,3)); //parent p= new child(1,2,3);
            display(new subchild(1,2,3,4));//parent p= new subchild(1,2,3,4);

            // parent p = new child(1, 2, 3);
         //   parent p = new subchild(1, 2, 3, 4);
         //   p.show();
        }
    }
}
