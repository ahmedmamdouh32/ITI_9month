using Day1.Entities;

namespace Day1.ViewModel
{
    public class CrsIdNameDeparment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department department { set; get; }
    }
}
