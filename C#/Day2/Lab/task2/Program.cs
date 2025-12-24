using System.Text.Json.Serialization.Metadata;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello Ahmed Mamdouh";
            string reversedSentence = "";
            string[] arr = sentence.Split(' ');
            foreach(string str in arr)
            {
                Console.WriteLine(str);
            }
            for(int i = arr.Length-1; i >= 0; i--)
            {
                reversedSentence += arr[i];
                reversedSentence += ' ';
            }
            Console.WriteLine(reversedSentence);
        }
    }
}
