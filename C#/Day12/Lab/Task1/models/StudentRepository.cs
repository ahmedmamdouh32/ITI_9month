using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.models
{
    internal static class StudentRepository
    {
        static List<Student> students = new List<Student>();

        public static void addStudent(Student s)
        {       
            students.Add(s);
        }
        public static void removeStudentById(int id)
        {
            foreach (Student s in students) { 
                if(s.Id == id)
                {
                    students.Remove(s);
                    break;
                }
            }
        }
        public static List<Student> getStudentByName(string name)
        {
            List<Student> result = new List<Student>();
            foreach (Student s in students)
            {
                if (s.Name.Contains(name))
                {
                    result.Add(s);
                }
            }
            return result;
        }
        public static List<Student> getStudents()
        {
            return students;
        }
    }
}
