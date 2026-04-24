using SOLID.SOLID_Case_Answer.Case_Answer_1_SRP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID.SOLID_Case.Case_1_SRP
{
    internal class BookService
    {

        IDbConnection connection;

        public BookService(IDbConnection _connection)
        {
            connection = _connection;
        }
        public void Save(Book book)
        {

        }

        public Book GetById(int id)
        {
            return null;//implemet here
        }
    }
}
