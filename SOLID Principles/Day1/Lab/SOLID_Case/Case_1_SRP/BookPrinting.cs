using SOLID.SOLID_Case_Answer.Case_Answer_1_SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case.Case_1_SRP
{
    internal class BookPrinting
    {

        public void Print(Book book)
        {
            Console.WriteLine($"Book Title : {book.Title}, Author : {book.Title}");
        }


        public void Print(List<Book> books)
        {
            foreach (Book book in books) {
                Print(book);
            }
        }


        public void PrintToFile(Book book, string filePath)
        {
            //implementation here
        }
    }
}
