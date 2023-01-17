--UC1
create database EmpPayroll;

--UC2
create table EmpPayrollTable(ID bigint Identity(1,1)Primary key,Name varchar(100),Salary bigint)
--UC4
Select * from EmpPayrollTable
--UC-3
Insert into EmpPayrollTable values('Reus',1000)
Insert into EmpPayrollTable values('Messi',2000)
Insert into EmpPayrollTable values('Pogba',1000)
Insert into EmpPayrollTable values('Ronaldo',2000,'M')
Insert into EmpPayrollTable values('Neymar',1000,'M')

update EmpPayrollTable set Salary =750 where ID=1
--UC5
select Name,Salary from EmpPayrollTable where ID=2
--UC6
Alter Table EmpPayrollTable Add Gender varchar(100)

update EmpPayrollTable set Gender='M' where ID=3 or ID =1
update EmpPayrollTable set Gender='M' where ID=2

Insert into EmpPayrollTable values('Mertens',1000,'F')
Insert into EmpPayrollTable values('Martha',2000,'F')
Insert into EmpPayrollTable values('Tony',2000,'F')
Insert into EmpPayrollTable values('Kerr',1000,'F')

Select SUM(Salary) as SumOfFemaleSalary from EmpPayrollTable where Gender='F' GROUP BY Gender;
Select SUM(Salary) as SumOfMaleSalary from EmpPayrollTable where Gender='M' GROUP BY Gender;

Select Count(ID) as CountofFemaleSalary from EmpPayrollTable where Gender='F' Group By Gender
Select Count(ID) as CountofMaleSalary from EmpPayrollTable where Gender='M' Group By Gender

--UC8
Alter Table EmpPayrollTable add Address varchar(max) Not Null default 'test'

Alter Table EmpPayrollTable add Phonenumber bigint Not Null default 0,Department varchar(100) Not Null default 'Zero'

update EmpPayrollTable set salary=24000,Department ='Manufacturing' where Gender='M'
--UC9
Alter Table EmpPayrollTable add BasicPay Int,Deductions Int, TaxablePay Int,IncomeTax Int, NetPay Int

update EmpPayrollTable set BasicPay =2800,Deductions=300,TaxablePay=200,IncomeTax=450,NetPay=19000  where Gender='M'
update EmpPayrollTable set Salary =40000,Phonenumber=454654666,Address='Chennai',Department='Sales',BasicPay =2000,Deductions=500,TaxablePay=800,IncomeTax=950,NetPay=29000  where Name='Kerr'
update EmpPayrollTable set Salary =35000,Phonenumber=354548696,Address='Banglore',Department='Supervising',BasicPay =18000,Deductions=300,TaxablePay=200,IncomeTax=450,NetPay=19000  where Name='Mertens'
update EmpPayrollTable set Salary =28000,Phonenumber=954634694,Address='Mumbai',Department='Marketing',BasicPay =28000,Deductions=380,TaxablePay=290,IncomeTax=550,NetPay=29000  where Name='Martha'
update EmpPayrollTable set Salary =21000,Phonenumber=954634694,Address='Mumbai',Department='Marketing',BasicPay =28000,Deductions=380,TaxablePay=290,IncomeTax=550,NetPay=29000  where Name='Tony'
update EmpPayrollTable set Phonenumber=454654666,Address='Hyderabad'  where Name='Reus'
update EmpPayrollTable set Phonenumber=35465766,Address='Mancheser'  where Name='Pogba'
update EmpPayrollTable set Phonenumber=467886555,Address='Chelsea'  where Name='Messi'
update EmpPayrollTable set Phonenumber=896764354,Address='anfield'  where Name='Neymar'
update EmpPayrollTable set Phonenumber=123454576,Address='hamers'  where Name='Ronaldo'
insert into EmpPayrollTable values('Therissa',23000,'F','Chennai',454654666,'Sales',20000,1000,1000,1000,26000)
insert into EmpPayrollTable values('Therissa',23000,'F','Chennai',454654666,'Marketing',20000,1000,1000,1000,26000)

create table Empolyee(EmployeeID bigint Identity(1,1)Primary key,EmployeeName varchar(100),PhoneNumber Bigint,Address varchar(max))

Insert into Empolyee values('Reus',464564423,'Chennai')
Insert into Empolyee values('Messaiah',86745345423,'mumbai')
Insert into Empolyee values('Dury',345678323,'Manchester')
Insert into Empolyee values('Peter',356547455,'Chepauk')
Select * from Empolyee
Drop table EmpolyeeInfoTable
create table Department (DepartmentID bigint identity(1,1)Primary key,DepartmentName varchar(100),EmployeesID Bigint)
Select * from Department
Drop table EmployeeDepartmentTable
Alter table Department add FOREIGN KEY(EmployeesID)  REFERENCES Empolyee(EmployeeID)
Select * from Department

Insert into Department values('Manufacutirng',1)
Insert into Department values('Sales',2)
Insert into Department values('Marketing',3)
Insert into Department values('Sales',4)

create table Salary(ID bigint Identity(1,1)Primary key,BasicPay Int,Deductions Int, TaxablePay Int,IncomeTax Int, NetPay Int,EmployeeID Bigint)

Alter table Salary add FOREIGN KEY(EmployeeID)  REFERENCES Empolyee(EmployeeID)

Insert into Salary values(20000,450,200,300,19150,1)
Insert into Salary values(20000,450,300,200,19150,2)
Insert into Salary values(22000,2000,1000,1000,18000,3)
Insert into Salary values(15000,500,550,300,13750,4)

Select * from Salary 

Select * from Empolyee e inner join Department where Empolyee.EmployeeID=Department.EmployeesID and EmployeeID=1


