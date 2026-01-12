using System.Text;

namespace Day7
{
    #region  operator overloading ,user define casting
    struct complex
    {
        public int real { get; set; }
        public int img { get; set; }
        public complex(int real , int img)
        {
            this.real = real;
            this.img = img;
        }
        public override string ToString()
        {
            return $"{real}+{img}i";
        }

        public static complex operator +(complex a, complex b)
        {
            //complex c = new complex();
            //c.real = a.real + b.real;
            //c.img = a.img + b.img;
            //return c;
            return new complex(a.real+b.real , a.img+b.img);
        }
        public static complex operator +(complex a, int b)
        {
            //complex c = new complex();
            //c.real = a.real + b.real;
            //c.img = a.img + b.img;
            //return c;
            return new complex(a.real + b, a.img );
        }

        public static complex operator ++(complex a)
        {
            a.real++;
            return a;
        }

        public static bool operator ==(complex a, complex b)
        {
            return (a.real == b.real && a.img == b.img);
        }
        public static bool operator !=(complex a, complex b)
        {
            return (a.real != b.real || a.img != b.img);
        }

        public static implicit operator int(complex a)
        {
            return a.real;
        }

        public static explicit operator float(complex a)
        {
            return (a.real+(0.1F*a.img));
        }
    }

    #endregion
    #region  indexer
    /// <summary>
    /// 
    /// </summary>
    class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public subject[] mysubjects { get; set; }
        /// <summary>
        /// constructor to construct student objects
        /// </summary>
        /// <param name="id"> student id</param>
        /// <param name="name"> student fullname</param>
        /// <param name="age"> student age</param>
        /// <param name="mysubj">  all student subjects</param>

        public student(int id=0 , string name=" ",int age = 6, subject[]mysubj=null)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.mysubjects = mysubj;
            
        }

        //define indexer
        //s["C#"]=40
        public int this[string subjName]
        {
            set
            {
                for (int i = 0; i < mysubjects.Length; i++)
                {
                    if (mysubjects[i].name == subjName)
                        mysubjects[i].duration = value;
                }

            }
            get
            {

                for (int i = 0; i < mysubjects.Length; i++)
                {
                    if (mysubjects[i].name == subjName)
                        return mysubjects[i].duration;
                }

                return 0;

            }
        }
        public int this[int id,string subjName]
        {
            set
            {
                for (int i = 0; i < mysubjects.Length; i++)
                {
                    if (mysubjects[i].name == subjName)
                        mysubjects[i].duration = value;
                }

            }
            get
            {

                for (int i = 0; i < mysubjects.Length; i++)
                {
                    if (mysubjects[i].name == subjName)
                        return mysubjects[i].duration;
                }

                return 0;

            }
        }

        public override string ToString()
        {
            //string txt = $"{id}-{name}-{age} years old \nSubject:\n";
            //for (int i = 0; i < mysubjects.Length; i++)
            //{
            //    txt += mysubjects[i].ToString() + "\n";
            //}

            //return txt;

            StringBuilder txt = new StringBuilder($"{id}-{name}-{age} years old \nSubject:\n");
           
           for (int i = 0; i < mysubjects.Length; i++)
            {
                txt.AppendLine( mysubjects[i].ToString() );
            }
            return txt.ToString();
        }
    }

    class subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public subject( int id=0, string name=" " ,int duration=6)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
        }
        public override string ToString()
        {
            return $"{id}-{name}-{duration}Hours";
        }
    }


    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region operator overloading

            // complex c1 = new complex(3, 4);
            // complex c2 = new complex(3,4);
            //c2 += c1;
            //complex c3 = c1 + c2;
            //Console.WriteLine(c2);
            //complex c4 = c1 + 1;
            //c2++;
            //Console.WriteLine(c2);
            //if (c1 == c2)
            //{
            //    Console.WriteLine("equal");
            //}
            //else Console.WriteLine("not equal");

            //non-overloading operator 
            //+= ,-=,*=,/= ,=,.,[],!,&&,||

            //user define casting
            //complex c1 = new complex(3, 4);
            ////int x =c1;
            //float x = (float)c1;
            //Console.WriteLine(x);

            #endregion
            #region indexer
            subject[] mysub = new subject[]
            {
                new subject(1,"C#",60),
                new subject(2,"SQL",40),
                new subject(3,"HTML",6),
                new subject(4,"js",24)
            };

            student s = new student(1, "ahmed mohamed", 20, mysub);
            //  s["C#"]=40;
            Console.WriteLine(s["SQL"]);
            // Console.WriteLine(s);

            //  s["C#"]=40;
            //s[1,"C#"]
            //s["SQL"]
            //s=5

            //StringBuilder txt = new StringBuilder();
            //txt.Append("dgdggdgdgdg dhdhdhdhdh");
            //txt.Remove()
            //Console.WriteLine(txt.Capacity);
            //Console.WriteLine(txt.Length);

            #endregion
        }
    }
}
