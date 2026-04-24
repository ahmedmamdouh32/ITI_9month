using SOLID.SOLID_Case_Answer.Case_Answer_1_SRP;
using SOLID.SOLID_Implement_2._2_1_SRP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case.Case_1_SRP
{
    internal class EmployeeService
    {
        IDbConnection connection;

        public EmployeeService(IDbConnection _connection)
        {
            connection = _connection;
        }
        public void Save(Employee emp)
        { 
            //implement here
        }

        public Employee getById(int id)
        {
            return null;//implemet here
        }
    }
}
