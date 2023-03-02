using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencySample1
{
    public class PermanentEmployee : IEmployee
    {
        //Service Implementation

        public string Fullname(string fName, string lName)
        {
            return "Permanent Employee Name is : " + fName + " " + lName;
        }

        public float CalculateSalary(float salary)
        {
            return salary * 30;
        }
    }
}
