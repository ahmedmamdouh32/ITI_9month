namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            //-------------------------- Query 1 --------------------------

            var Q1 = numbers.Order().Distinct();

            foreach (var n in Q1)
            {
                Console.WriteLine(n);
            }


            //-------------------------- Query 2 --------------------------

            var Q2 = numbers.Order().Distinct().Select( n => new {number = n , multi = n*n});

            foreach (var n in Q2) 
            {
                Console.WriteLine(n);
            }


            //-------------------------- Query 3 --------------------------

            //method expression:
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            var Q3 = names.Where(name => name.Length == 3);
            foreach (var name in Q3)
            {
                Console.WriteLine(name);
            }
            //query expression:
            var Q3_Query = from name in names
                           where name.Length == 3
                           select name;

            foreach (var name in Q3_Query)
            {
                Console.WriteLine(name);
            }

            //-------------------------- Query 4 --------------------------

            //method expression:
            var Q4 = names.Where(n => n.ToLower().Contains("a"));

            foreach (var name in Q4)
            {
                Console.WriteLine(name);
            }

            //query expression:
            var Q4_Query = from name in names
                           where name.ToLower().Contains("a")
                           select name;
            foreach (var name in Q4_Query)
            {
                Console.WriteLine(name);
            }

            //-------------------------- Query 5 --------------------------

            //method expression:
            var Q5 = names.Take(2);
            foreach(var name in Q5)
            {
                Console.WriteLine(name);
            }

            //query expression:

            var Q5_Query = (from name in names
                            select name).Take(2);

            foreach (var name in Q5_Query)
            {
                Console.WriteLine(name);
            }



            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Mohammed",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 33, Name = "UML" }
                    }
                },

                new Student()
                {
                    ID = 2,
                    FirstName = "Mona",
                    LastName = "Gala",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 34, Name = "XML" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },

                new Student()
                {
                    ID = 3,
                    FirstName = "Yara",
                    LastName = "Yousf",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },

                new Student()
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Ali",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 33, Name = "UML" }
                    }
                }
            };

            //-------------------------- Query 6 --------------------------
            var Q6 = students.Select(s => new { name = $"{s.FirstName} {s.LastName}", NoOfSubjects = s.Subjects.Length});

            foreach (var s in Q6)
            {
                Console.WriteLine(s);
            }

            //-------------------------- Query 7 --------------------------

            var Q7 = students.OrderByDescending(student => student.FirstName).ThenBy(student => student.LastName).Select(student => new {name = $"{student.FirstName} {student.LastName}"});
            foreach (var s in Q7)
            {
                Console.WriteLine(s);
            }


            //-------------------------- Query 8 --------------------------

            var Q8 = students.SelectMany(s => s.Subjects, (s, sub) => new
            {
                StudentName = s.FirstName + " " + s.LastName,
                SubjectName = sub.Name
            });

             
            foreach (var s in Q8)
            {
                Console.WriteLine(s);
            }

            //-------------------------- Query 9 --------------------------

            var Q9 = students.SelectMany(s => s.Subjects,(s, sub) => new
            {
                StudentName = s.FirstName + " " + s.LastName,
                SubjectName = sub.Name
            }).GroupBy(x => x.StudentName);

            foreach (var group in Q9)
            {
                Console.WriteLine(group.Key); 

                foreach (var item in group)
                {
                    Console.WriteLine("  " + item.SubjectName);
                }
            }



        }
    }
}
