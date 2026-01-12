using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Task1
{
    internal class Program
    {
        public delegate string LibraryDelegate(Book b);
        public class Book
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string[] Authors { get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }
            public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
            {
                ISBN = _ISBN;
                Title = _Title;
                Authors = _Authors;
                PublicationDate = _PublicationDate;
                Price = _Price;
            }
            public override string ToString() => $"ISBN:{ISBN}, Title:{Title}, Publication Date:{PublicationDate}, Price{string.Format("{0:C}",Price)}";
            
        }

        public class BookFunctions
        {
            public static string GetTitle(Book B) => B.Title;


            public static string GetAuthors(Book B)
            {
                StringBuilder result = new StringBuilder();
                foreach (string author in B.Authors)
                {
                    result.Append(author + ", ");
                }
                return result.ToString();
            }
            public static string GetPrice(Book B) => string.Format("{0:C}", B.Price);
        }
        public class LibraryEngine
        {
            //----------------  Built in Delegate  ----------------
            //public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
            //{
            //    foreach (var book in bList)
            //    {
            //        Console.WriteLine(fPtr(book));
            //    }
            //}
            //----------------  User-defined Delegate  ----------------
            public static void ProcessBooks(List<Book> bList, LibraryDelegate fPtr)
            {
                foreach (var book in bList)
                {
                    Console.WriteLine(fPtr(book));
                }
            }
        }
        static void Main(string[] args)
        {
            Book b1 = new Book(_ISBN: "1203E", _Title: "Book1 Title", _Authors: new string[]{ "Ahmed", "Ashraf" }, _PublicationDate:new DateTime(2002,1,12), _Price:120);
            Book b2 = new Book(_ISBN: "1203E", _Title: "Book2 Title", _Authors: new string[]{ "Ayman", "Abbas" }, _PublicationDate:new DateTime(2002,1,12), _Price:130);
            Book b3 = new Book(_ISBN: "1203E", _Title: "Book3 Title", _Authors: new string[]{ "Ahmed", "Tarek" }, _PublicationDate:new DateTime(2002,1,12), _Price:140);
            Book b4 = new Book(_ISBN: "1203E", _Title: "Book4 Title", _Authors: new string[]{ "Hany", "Shaker" }, _PublicationDate:new DateTime(2002,1,12), _Price:150);



            List<Book> Library = new List<Book>();
            Library.Add(b1);
            Library.Add(b2);
            Library.Add(b3);
            Library.Add(b4);
            //LibraryEngine.ProcessBooks(Library, BookFunctions.GetAuthors);

            //Anonymous Method : 
            LibraryEngine.ProcessBooks(Library, delegate(Book B) { return B.ISBN; });

            //Lambda Expression:
            LibraryEngine.ProcessBooks(Library, B => B.PublicationDate.ToString("yyyy-MMM-dd"));

        }
    }
}
