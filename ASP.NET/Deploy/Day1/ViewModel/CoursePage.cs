using Day1.Entities;

namespace Day1.ViewModel
{
    public class CoursePage
    {
        public List<Course> Courses { set; get; }
        public int pageNumber { set; get; }
        public int PagesCount { set; get; }
        public string SearchText { set; get; }
        public string? ImageUrl { get; set; }
    }
}
