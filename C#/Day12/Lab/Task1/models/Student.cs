public enum Gender
{
    male,
    female
}
namespace Task1
{
     public class Student
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public Gender Gender { get; set; }
    }
}
