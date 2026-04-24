using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case.Case_1_SRP.Interfaces
{

     
    public interface IWorker
    {

        int netSalary { set; get; }
        double getSalary();
    }
}
