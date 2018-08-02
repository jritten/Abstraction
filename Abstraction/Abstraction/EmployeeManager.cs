using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class EmployeeManager
    {
        public int GetTotalSalary(Employee[] employees)
        {
            int totalSalary = 0;
            foreach(Employee employee in employees)
            {

                totalSalary += employee.GetSalary();
            }
            return totalSalary;
        }
    }
}
