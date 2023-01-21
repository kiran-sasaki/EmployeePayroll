using EmpPayrollService;

namespace EmployeePayrollTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void GivenSalary_WhenPassed_ShouldReturnEmployeeUpdated()
        //{
        //    PayRoll roll = new PayRoll();
        //    roll.Name = "Reus";
        //    roll.Address = "Cheapuk";
        //    roll.PhoneNumber = "46645343478";
        //    EmployeeRepository employeeRepository = new EmployeeRepository();
        //    int result = employeeRepository.UpdateEmployee(roll);
        //    Assert.AreEqual(1, result);
        //}
        //[Test]
        //public void GivenName_WhenPassed_ShouldReturnDeleted()
        //{
        //    PayRoll roll = new PayRoll();
        //    roll.Name = "Kerr";
        //    EmployeeRepository repository = new EmployeeRepository();
        //    int result = repository.DeleteEmployee(roll);
        //    Assert.AreEqual(1,result);
        //}
        //[Test]
        //public void AddEmployee_ShouldReturnAdded()
        //{
        //    PayRoll roll = new PayRoll();
        //    roll.Name = "Marnus";
        //    roll.Salary = 23000;
        //    roll.Gender = 'M';
        //    roll.Address = "Dhaka";
        //    roll.PhoneNumber = "59776654223";
        //    roll.Department = "Sales";
        //    roll.BasicPay = 150000;
        //    roll.Deductions = 1000;
        //    roll.TaxablePay = 1000;
        //    roll.IncomeTax = 1000;
        //    roll.NetPay = 12000;
        //    EmployeeRepository repository = new EmployeeRepository();
        //    int result = repository.AddEmployee(roll);
        //    Assert.AreEqual(1, result);
        //}
        [Test]
        public void MultipleEmployee()
        {
            List<PayRoll> payRoll = new List<PayRoll>();
            payRoll.Add(new PayRoll { Name = "Kiran", Salary=23000,Gender='M',Address="Mumbai",PhoneNumber="3254633132",Department="marketing",BasicPay=15000,Deductions=1000,TaxablePay=1000,IncomeTax=1000,NetPay=15000});
            payRoll.Add(new PayRoll { Name = "Baki", Salary = 23000, Gender = 'M', Address = "chennai", PhoneNumber = "3254633132", Department = "marketing", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            payRoll.Add(new PayRoll { Name = "Luffy", Salary = 23000, Gender = 'M', Address = "Mumbai", PhoneNumber = "3254633132", Department = "marketing", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            payRoll.Add(new PayRoll { Name = "Uzumaki", Salary = 23000, Gender = 'M', Address = "Mumbai", PhoneNumber = "3254633132", Department = "marketing", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            payRoll.Add(new PayRoll { Name = "Jozu", Salary = 23000, Gender = 'M', Address = "Mumbai", PhoneNumber = "3254633132", Department = "marketing", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            payRoll.Add(new PayRoll { Name = "Yagami", Salary = 23000, Gender = 'M', Address = "Mumbai", PhoneNumber = "3254633132", Department = "marketing", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            payRoll.Add(new PayRoll { Name = "Kira", Salary = 23000, Gender = 'M', Address = "Mumbai", PhoneNumber = "3254633132", Department = "marketing", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            EmployeePayrollOperations payrollOperations = new EmployeePayrollOperations();
            DateTime startDateTime= DateTime.Now;
            payrollOperations.AddEmployeestolist(payRoll);
            DateTime stopDateTime= DateTime.Now;
            Console.WriteLine("Duration Without Thread "+(stopDateTime-startDateTime));
        }
    }
}