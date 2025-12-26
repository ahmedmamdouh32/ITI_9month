namespace Task1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for static number of courses:
            int studentsNumber = 0;
            int coursesNumber = 0;
            Console.WriteLine("Enter Students Number :");
            studentsNumber = int.Parse(Console.ReadLine());
            int MAX_COURSES = 0;

            int[][] studentsCoursesGrades = new int[studentsNumber][];

            //entering data:
            for (int studentIndex = 0; studentIndex < studentsCoursesGrades.GetLength(0); studentIndex++)
            {
                Console.WriteLine($"Enter Number of Courses for Student NO. {studentIndex+1}");
                coursesNumber = int.Parse(Console.ReadLine());
                if (coursesNumber > MAX_COURSES) MAX_COURSES = coursesNumber;//updating the maximum n. of courses
                studentsCoursesGrades[studentIndex] = new int[coursesNumber];
                for(int courseIndex = 0; courseIndex < coursesNumber; courseIndex++)
                {
                    Console.WriteLine($"Enter Data for course NO.{courseIndex+1}");
                    studentsCoursesGrades[studentIndex][courseIndex] = int.Parse(Console.ReadLine());
                }
            }

            //Displaying Data
            for (int studentIndex = 0; studentIndex < studentsCoursesGrades.Length; studentIndex++)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Data for Student NO. {studentIndex + 1}");
                for (int courseIndex = 0; courseIndex < studentsCoursesGrades[studentIndex].Length; courseIndex++)
                {
                    Console.WriteLine($"Course {courseIndex + 1} Grade : {studentsCoursesGrades[studentIndex][courseIndex]}");
                }
            }

            //------------------------Calculating Students Total Grades------------------------
            int[] studentsSumOfGrades = new int[studentsNumber];

            for (int studentIndex = 0; studentIndex < studentsCoursesGrades.Length; studentIndex++)
            {
                for (int courseIndex = 0; courseIndex < studentsCoursesGrades[studentIndex].Length; courseIndex++)
                {
                    studentsSumOfGrades[studentIndex] += studentsCoursesGrades[studentIndex][courseIndex];
                }
            }
            //-------------------------Displaying Students Total Grades-------------------------
            Console.WriteLine("---------Displaying Total Grades of each student:---------");
            for (int studentIndex = 0; studentIndex < studentsCoursesGrades.Length; studentIndex++)
            {
                //Console.WriteLine("Each Student Total Grades : ");
                Console.WriteLine($"Total Grade of Student NO. {studentIndex + 1} = {studentsSumOfGrades[studentIndex]}");
            }

            ////------------------------Calculating Average Grade of Courses------------------------
            float[] CoursesAveGrades = new float[MAX_COURSES];
            int[] StudentsInEachCourse = new int[MAX_COURSES];

            for (int studentIndex = 0; studentIndex < studentsCoursesGrades.Length; studentIndex++)
            {
                for (int courseIndex = 0; courseIndex < studentsCoursesGrades[studentIndex].Length; courseIndex++)
                {
                    CoursesAveGrades[courseIndex] += studentsCoursesGrades[studentIndex][courseIndex];
                    StudentsInEachCourse[courseIndex]++;
                }
            }

            for(int courseIndex = 0; courseIndex < MAX_COURSES; courseIndex++)
            {
                CoursesAveGrades[courseIndex] /= StudentsInEachCourse[courseIndex];


            }
            Console.WriteLine("---------------Average Course Degree----------------");
            for (int courseIndex = 0; courseIndex < MAX_COURSES; courseIndex++)
            {
                Console.WriteLine($"Course {courseIndex + 1} Average Grades : {CoursesAveGrades[courseIndex]}");
            }
        }
    }
}
