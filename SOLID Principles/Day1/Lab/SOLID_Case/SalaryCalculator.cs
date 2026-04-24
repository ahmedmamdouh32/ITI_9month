using SOLID.SOLID_Case.Case_1_SRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case
{
    static class SalaryCalculator
    {

        static double CalculateSalary(IWorker worker)
        {
            return worker.getSalary();
        }


        static double CalculateWorkersSalary(List<IWorker> workers)
        {
            double result = 0;
            foreach (IWorker worker in workers)
            {
                result += worker.getSalary();
            }
            return result;
        }
    }
}
