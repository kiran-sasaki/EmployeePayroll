using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollService
{
    public class EmployeeRepository
    {
        public static string connectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=EmpPayroll; integrated security=true";
        SqlConnection sqlconnection = new SqlConnection(connectionString);

        public int AddEmployee(PayRoll roll)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand("spAddEmployee", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", roll.Name);
                    command.Parameters.AddWithValue("@Salary", roll.Salary);
                    command.Parameters.AddWithValue("@Gender", roll.Gender);
                    command.Parameters.AddWithValue("@Address", roll.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", roll.PhoneNumber);
                    command.Parameters.AddWithValue("@Department", roll.Department);
                    command.Parameters.AddWithValue("@BasicPay", roll.BasicPay);
                    command.Parameters.AddWithValue("@Deductions", roll.Deductions);
                    command.Parameters.AddWithValue("@TaxablePay", roll.TaxablePay);
                    command.Parameters.AddWithValue("@IncomeTax", roll.IncomeTax);
                    command.Parameters.AddWithValue("@NetPay", roll.NetPay);
                    int result = command.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Employee Added Successfully");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int UpdateEmployee(PayRoll roll)
        {
            try
            {
                using(this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command1 = new SqlCommand("spUpdateEmployeeInfo", this.sqlconnection);
                    command1.CommandType = CommandType.StoredProcedure;
                    command1.Parameters.AddWithValue("@Name", roll.Name);
                    command1.Parameters.AddWithValue("@Address", roll.Address);
                    command1.Parameters.AddWithValue("@PhoneNumber", roll.PhoneNumber);
                    int result = command1.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Employee Updated Successfully");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int DeleteEmployee(PayRoll roll)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command1 = new SqlCommand("spDeleteEmployee", this.sqlconnection);
                    command1.CommandType = CommandType.StoredProcedure;
                    command1.Parameters.AddWithValue("@Name", roll.Name);
                    int result = command1.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Employee Deleted Successfully");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<PayRoll> GetEmployee()
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    List<PayRoll> EmpList = new List<PayRoll>();
                    SqlCommand command = new SqlCommand("spGetEmp", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    this.sqlconnection.Close();
                    foreach(DataRow dr in table.Rows)
                    {
                        EmpList.Add(new PayRoll
                        {
                            Name = Convert.ToString(dr["Name"]),
                            Salary = Convert.ToInt32(dr["Salary"]),
                            Gender = Convert.ToChar(dr["Gender"]),
                            Address = Convert.ToString(dr["Address"]),
                            PhoneNumber = Convert.ToString(dr["PhoneNumber"]),
                            Department = Convert.ToString(dr["Department"]),
                            BasicPay = Convert.ToDouble(dr["BasicPay"]),
                            Deductions = Convert.ToDouble(dr["BasicPay"]),
                            TaxablePay = Convert.ToDouble(dr["TaxablePay"]),
                            IncomeTax = Convert.ToDouble(dr["IncomeTax"]),
                            NetPay = Convert.ToDouble(dr["NetPay"])

                        });
                    }
                    return EmpList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
