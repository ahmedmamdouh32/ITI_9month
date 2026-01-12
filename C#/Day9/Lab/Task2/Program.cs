using System.Xml.Linq;

namespace Task2
{
    internal class Program
    {
        public interface ISchoolMember
        {
            public string Name {  get; set; }
            public string DisplayInfo();
        }

        public interface IPrintable
        {
            public string printReport();
        }


        public interface IAttendable
        {
            bool MarkAttendance();
        }


        public class Student : ISchoolMember
        {
            public string Name { get; set ; }

            public string DisplayInfo()
            {
                return $"Student Name : {Name}";
            }
        }

        public class Teacher : ISchoolMember
        {
            public string Name { get; set; }
            public string DisplayInfo()
            {
                return $"Teacher Name : {Name}";
            }
        }




        public class Administartor : ISchoolMember
        {
            public string Name { get; set; }
            public string DisplayInfo()
            {
                return $"Adminstartor Name : {Name}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
