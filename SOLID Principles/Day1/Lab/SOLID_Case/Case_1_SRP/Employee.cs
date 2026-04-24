using SOLID.SOLID_Case.Case_1_SRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Implement_2._2_1_SRP
{
    public class Employee : IWorker
    {
        //public void SaveEmployee(Employee employee)
        //{
        //    // Code to save employee to the database
        //}

        public int netSalary { set; get; }

        //public void CalculateSalary(Employee employee)
        //{
        //    // Code to calculate employee's salary
        //}

        public double getSalary()
        {
            return netSalary * 0.95;
        }
    }
}
