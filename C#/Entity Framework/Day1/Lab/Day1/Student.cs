using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] Subjects { get; set; }


        public override string ToString()
        {
            StringBuilder result= new StringBuilder();
            result.Append($"ID:{ID}, Name:{FirstName} {LastName}");
            foreach(Subject s in Subjects)
            {
                result.AppendLine(s.ToString());
            }

            return result.ToString();
        }

    }
}
