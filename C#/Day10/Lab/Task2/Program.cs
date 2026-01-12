using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task2
{
    public class Question
    {
        static long _ID = 0;
        public long ID { get; }
        public string body { set; get;}
        public Question()
        {
            ID = ++_ID;
        }
        public Question(string body):this()
        {
            this.body = body;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(this.ID, this.body);
        }
        public override bool Equals(object? obj)
        {
            Question? temp = obj as Question;
            if (temp != null)
            {
                return (temp.ID == ID && temp.body == body);
            }
            else
            {
                throw new NullReferenceException("Reference to null");
            }
        }
    }

    public class File
    {
        static public void writeToFile(string filePath, string text)
        {
            System.IO.File.AppendAllText(filePath, $"{text}\n");
        }
    }
    public class QuestionList : List<Question>
    {


        //List<Question>
        public new void Add(string text,string filePath)
        {
            Question q = new Question(text);
            base.Add(q);
            File.writeToFile(filePath, text);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach(Question q in this)
            {
                result.AppendLine(q.body);
            }
            return result.ToString();
        }

    public class Choice
    {
        static long _ID = 0; 
        public long questionID { get; }
        public long ID { get; }
        public string body { set; get;}
        public int Score { set; get;}

        public Choice(long questionID)
        {
            ID = ++_ID;
            this.questionID = questionID;
        }
        public Choice(string body, long questionID):this(questionID)
        {
            this.body = body;
        }
        public Choice(String body, long questionID, int score):this(body,questionID)
        {
            this.Score = score;
        }
        public override string ToString()
        {
            return $"{body}, answer related to question ID :{questionID}";
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                string filePath = @"C:\Users\adminstrator\Documents\ITI_9Months\C#\Day10\Lab\Task2\logs.txt";
                Dictionary<Question, List<Choice>> exam = new Dictionary<Question, List<Choice>>();

                List<Choice> choices = new List<Choice> {
                new Choice(questionID:1, body:"Answer 1 to Q1"),
                new Choice(questionID:1, body:"Answer 2 to Q1"),
                new Choice(questionID:1, body:"Answer 3 to Q1"),
                new Choice(questionID:1, body:"Answer 4 to Q1"),
                };

                exam.Add(new Question("Q1 body"), choices);
                foreach (var item in exam)
                {
                    Console.WriteLine(item.Key);
                    foreach (var choice in item.Value)
                    {
                        Console.WriteLine(choice);
                    }
                }

                QuestionList q1 = new QuestionList();
                q1.Add("Question 1 content", filePath);
                q1.Add("Question 2 content", filePath);
                q1.Add("Question 3 content", filePath);

                Console.WriteLine(q1);
            }
        }
    }
}
