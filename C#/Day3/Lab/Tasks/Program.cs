namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for static number of courses:
            
            Console.WriteLine("Enter Students Number :");
            int studentsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Courses Number :");
            int coursesNumber = int.Parse(Console.ReadLine());

            int[,] studentsCoursesGrades = new int[studentsNumber,coursesNumber];

            //entering data:
            for(int studentIndex=0; studentIndex < studentsCoursesGrades.GetLength(0); studentIndex++)
            {
                Console.WriteLine($"Data for Student NO. {studentIndex+1}");
                for(int courseIndex = 0; courseIndex < studentsCoursesGrades.GetLength(1); courseIndex++)
                {
                    Console.WriteLine($"Enter Grades Of Course Number {courseIndex+1}");
                    studentsCoursesGrades[studentIndex, courseIndex] = int.Parse(Console.ReadLine());
                }
            }

            //Displaying Data
            for (int studentIndex = 0; studentIndex < studentsCoursesGrades.GetLength(0); studentIndex++)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Data for Student NO. {studentIndex+1}");
                for (int courseIndex = 0; courseIndex < studentsCoursesGrades.GetLength(1); courseIndex++)
                {
                    Console.WriteLine($"Course {courseIndex+1} Grade : {studentsCoursesGrades[studentIndex,courseIndex]}");
                }
            }

            //------------------------Calculating Students Total Grades------------------------
            int[] studentsSumOfGrades = new int[studentsNumber];

            for (int studentIndex = 0; studentIndex < studentsCoursesGrades.GetLength(0); studentIndex++)
            {
                for (int courseIndex = 0; courseIndex < studentsCoursesGrades.GetLength(1); courseIndex++)
                {
                    studentsSumOfGrades[studentIndex] += studentsCoursesGrades[studentIndex,courseIndex];
                }
            }
            //-------------------------Displaying Students Total Grades-------------------------
            Console.WriteLine("---------Displaying Total Grades of each student:---------");
            for (int studentIndex = 0; studentIndex < studentsCoursesGrades.GetLength(0); studentIndex++)
            {
                //Console.WriteLine("Each Student Total Grades : ");
                Console.WriteLine($"Total Grade of Student NO. {studentIndex + 1} = {studentsSumOfGrades[studentIndex]}");
            }

            //------------------------Calculating Average Grade of Courses------------------------
            float[] CoursesAveGrades = new float[coursesNumber];

            for (int courseIndex = 0; courseIndex < studentsCoursesGrades.GetLength(1); courseIndex++)
            {
                for (int studentIndex = 0; studentIndex < studentsCoursesGrades.GetLength(0); studentIndex++)
                {
                    CoursesAveGrades[courseIndex] += studentsCoursesGrades[studentIndex, courseIndex];
                }
                CoursesAveGrades[courseIndex] /= (float)studentsNumber;
            }

            Console.WriteLine("-------------------------------");
            for (int courseIndex = 0; courseIndex < studentsCoursesGrades.GetLength(1); courseIndex++)
            {
                Console.WriteLine($"Course {courseIndex+1} Total Grades : {CoursesAveGrades[courseIndex]}");
            }








        }
    }
}
