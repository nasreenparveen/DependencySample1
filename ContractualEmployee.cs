using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencySample1
{
    class ContractualEmployee : IEmployee
    {//Service Implementations
        
        public string Fullname(string fName, string lName)
        {
            return "Contractual Employee Name is : "+fName + " " + lName;
        }

        public float CalculateSalary(float salary,float hours)
        {
            return salary * hours;

        }
    }
}
