using System.Xml.Linq;

namespace Task1
{
    internal class Program
    {

        public record Point3D(int x, int y, int z)
        {
            public int X { get; } = x;
            public int Y { get; } = y;
            public int Z { get; } = z;
        }

        public class Point : IComparable<Point>, ICloneable
        {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }

            public Point()
            {
                x = y = z = 0;
            }
            public Point(int n)
            {
                x = y = z = n;
            }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public Point(int x, int y, int z) : this(x, y)
            {
                this.z = z;
            }

            public void Deconstruct(out int x,out  int y,out int z)
            {
                x = this.x;
                y = this.y;
                z = this.z;
            }


            public override string ToString()
            {
                return $"Point Coordinates : ({x}, {y}, {z})";
            }

            public static explicit operator string(Point p)
            {
                return $"Point Coordinates : ({p.x}, {p.y}, {p.z})";
            }

            public override bool Equals(object? obj)
            {
                if (obj is Point)
                {
                    Point temp = (Point)obj;
                    return this.x == temp.x && y == temp.y && z == temp.z;
                }
                return false;
            }

            int IComparable<Point>.CompareTo(Point? other)
            {
                //if (x > other.x) return 1;
                //else if (x < other.x) return -1;
                //else
                //{
                //    if (y > other.y) return 1;
                //    else if (y < other.y) return -1;
                //    else
                //    {
                //        return 0;
                //    }
                //}

                if(x == other.x) 
                    return y.CompareTo(other.y);
                else 
                    return x.CompareTo(other.x);
            }

            public object Clone()
            {
                return new Point(x, y, z);
            }

            public static bool operator ==(Point p1, Point p2)
            {
                return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
            }
            public static bool operator !=(Point p1, Point p2)
            {
                return !(p1 == p2);
            }
        }


        public class Math
        {
            static public int Add(int a, int b)
            {
                return a + b;
            }
            static public int Subtract(int a, int b)
            {
                return a - b;
            }
            static public int Multiply(int a, int b)
            {
                return a * b;
            }
            static public float Divide(int a, int b)
            {
                if (b != 0)
                    return (float)a / b;
                else
                    throw new Exception();
            }

        }


        static void Main(string[] args)
        {
            //#region Task1
            //Point p1 = new Point();
            //Point p2 = new Point();
            //bool status = false;
            //int userInput = 0;
            //Console.WriteLine("Initializing Point P1");
            //do
            //{
            //    Console.WriteLine("Enter value for x :");
            //    status = int.TryParse(Console.ReadLine(), out userInput);
            //} while (status != true);
            //p1.x = userInput;

            //do
            //{
            //    Console.WriteLine("Enter value for y :");
            //    status = int.TryParse(Console.ReadLine(), out userInput);
            //} while (status != true);
            //p1.y = userInput;

            //do
            //{
            //    Console.WriteLine("Enter value for z :");
            //    status = int.TryParse(Console.ReadLine(), out userInput);
            //} while (status != true);
            //p1.z = userInput;

            //Console.WriteLine("Initializing Point P2");
            //do
            //{
            //    Console.WriteLine("Enter value for x :");
            //    status = int.TryParse(Console.ReadLine(), out userInput);
            //} while (status != true);
            //p2.x = userInput;

            //do
            //{
            //    Console.WriteLine("Enter value for y :");
            //    status = int.TryParse(Console.ReadLine(), out userInput);
            //} while (status != true);
            //p2.y = userInput;

            //do
            //{
            //    Console.WriteLine("Enter value for z :");
            //    status = int.TryParse(Console.ReadLine(), out userInput);
            //} while (status != true);
            //p2.z = userInput;

            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(p1 == p2);
            //Console.WriteLine(p1 != p2);
            //#endregion

            //#region Task2
            //Console.WriteLine(Math.Add(1, 2));
            //Console.WriteLine(Math.Subtract(1, 2));
            //Console.WriteLine(Math.Multiply(1, 2));
            //Console.WriteLine(Math.Divide(1, 2));
            //#endregion


            
            Point p5 = new Point(1,2,3);
            var (x, y, z) = p5;

            Console.WriteLine(p5);

            Point[] points =
            {
                new Point(1,2,3),
                new Point(4,5,12),
                new Point(4,4,31),
                new Point(6,3,2),
                new Point(1,2,14)
            };

            Array.Sort(points);
            foreach (var p in points)
            {
                Console.WriteLine(p);
            }


            Point p6 = (Point)p5.Clone();
            Console.WriteLine(p6); //same values
            Console.WriteLine(p5.GetHashCode());
            Console.WriteLine(p6.GetHashCode()); //different hashcode


            Point3D p7 = new Point3D(1, 2, 3);
            Console.WriteLine(p7);
            Point3D p8 = p7 with { y = 12 };
            Console.WriteLine(p8);

            Point3D p9 = new Point3D(1,2,3);
            Console.WriteLine(p9);



        }
    }
}
