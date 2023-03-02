using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencySample1
{
   public class FinanceDept
   {
       public IEmployee _Employee;

       public FinanceDept(IEmployee employee)
       {
           this._Employee = employee;
       }

       public void EmployeeName(string fname,string lname)
       {
        Console.WriteLine(this._Employee.Fullname(fname,lname));
       }

       public void EmployeeSalary(string type)
       {
          
        }

   }
}
