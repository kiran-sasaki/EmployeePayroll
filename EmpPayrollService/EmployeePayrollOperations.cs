using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollService
{
    public class EmployeePayrollOperations
    {
        public List<PayRoll> EmployeePayrollList = new List<PayRoll>();
        public void AddEmployeestolist(List<PayRoll> EmployeePayrollList)
        {
            EmployeePayrollList.ForEach(data =>
            {
                Console.WriteLine("Employee Being Added" + data.Name);
                this.AddEmployeePayroll(data);
                Console.WriteLine("Employee Added" + data.Name);
            });
            Console.WriteLine(this.EmployeePayrollList.ToString());
        }
        public void AddEmployeePayroll(PayRoll roll)
        {
            EmployeePayrollList.Add(roll);
        }
    }
}
