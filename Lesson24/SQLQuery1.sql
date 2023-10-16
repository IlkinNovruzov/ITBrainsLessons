create database Company
use Company
create table Customers
(ID int primary key identity,
Name varchar(50),
Surname varchar(50), 
SALARY float)
insert into Customers(Name, Surname, Salary) values
('Ilkin','Novruzov',700),
('Nasir','Asadov',800) 
select * from Customers
update Customers set Salary=900 where ID=1
delete from Customers where ID=1
select AVG(SALARY) as Average from customers
select * from Customers where SALARY<(select AVG(SALARY) from customers )
select Min(SALARY) as MinSalary from Customers
select Name from Customers where SALARY=(select Min(SALARY) as MinSalary from Customers)
select Surname from Customers where SALARY=(select Max(SALARY) as MinSalary from Customers)
