namespace EmpPayrollService
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            PayRoll roll = new PayRoll();
            roll.Name = "Marnus";
            roll.Salary = 23000;
            roll.Gender = 'M';
            roll.Address = "Dhaka";
            roll.PhoneNumber = "59776654223";
            roll.Department = "Sales";
            roll.BasicPay = 150000;
            roll.Deductions = 1000;
            roll.TaxablePay = 1000;
            roll.IncomeTax = 1000;
            roll.NetPay = 12000;
            //repository.AddEmployee(roll);
            roll.Name = "Marnus";
            roll.Address = "Chetpet";
            roll.PhoneNumber = "786754344325";
            //repository.UpdateEmployee(roll);
            //roll.Name = "Marnus";
            //repository.DeleteEmployee(roll);
            repository.GetEmployee();
        }
    }
}
