using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencySample1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FinanceDept fcoDept1 = new FinanceDept(new ContractualEmployee());
            fcoDept1.EmployeeName("John","R");

            FinanceDept fcoDept2 = new FinanceDept(new PermanentEmployee());
            fcoDept2.EmployeeName("Ray","Miller");

            Console.ReadLine();

        }
    }
}
