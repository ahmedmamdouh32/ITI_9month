using System.Text;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam ex1 = new Exam();

            int score = 80;
            double finalScore = 40;
            char grade;
            string report = ex1.ProcessExamResult(studentName: "ahmed", rawFinalScore: in score, normalizedFinalScore: out finalScore, grade: out grade, examScores: [10, 10, 20, 5, 5, 10, 20]);
            Console.WriteLine(report);
        }
    }
    public class Exam
    {
        public string ProcessExamResult(string studentName, in int rawFinalScore, out double normalizedFinalScore, out char grade, string institution = "ITI", params int[] examScores)
        {

            if (examScores.Length == 0)
            {
                normalizedFinalScore = 0;
            }


            normalizedFinalScore = rawFinalScore + 15;

            if (normalizedFinalScore >= 90) grade = 'A';
            else if (normalizedFinalScore >= 80) grade = 'B';
            else if (normalizedFinalScore >= 70) grade = 'C';
            else grade = 'F';

            StringBuilder reportString = new StringBuilder();

            for (int i = 0; i < examScores.Length; i++)
            {
                reportString.AppendLine($"Question ({i + 1}) score : {examScores[i]}");
            }
            reportString.AppendLine($"Student Grade : {grade}");

            return reportString.ToString();
        }

    }
}
