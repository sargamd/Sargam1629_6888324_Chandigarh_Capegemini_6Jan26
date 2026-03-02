create database Employeedb
use Employeedb
create table [dbo].[Address](
	[AddressID] [int] IDENTITY(1,1) not null,
	[Street] [varchar](255) NULL,
	[CITY] [varchar](100) NULL,
	[State] [varchar](100) NULL,
	[PostalCode] [varchar](20) NULL)
create table Employee(
	[EmployeeID] [int] IDENTITY(1,1) not null,
	[FirstName] [varchar](100),
	LastName varchar(100),
	Email varchar(100),
	AddressID int null
	)
insert into Employee values('John','Doe','johndoe@example.com',1)
insert into Employee values('Jane','Doe','janendoe@example.com',2)
insert into Employee values('Ramesh','Sharma','ramesh@example.com',3)
insert into Employee values('Ramesh','Sharma','ramesh@example.com',4)
drop table employee
drop table address
DROP PROCEDURE DeleteEmployee;
insert into Address values('1234 Elm Street','Springfield','Sydney',62704)
insert into Address values('5678 Oak Street','Delhi','Haryana',35601)
insert into Address values('123 Patia','BBSR','India',755019)
insert into Address values('123 Patia','BBSR','India',755019)

create procedure [dbo].[CreateEmployeeWithAddress]
@FirstName varchar(100),
@LastName varchar(100),
@Email varchar(100),
@Street varchar(255),
@City varchar(100),
@State varchar(100),
@PostalCode varchar(20)
as
begin
declare @AddressId int;

insert into address(Street,City,State,PostalCode) values(@Street,@City,@State,@PostalCode);
set @AddressId=SCOPE_IDENTITY();
insert into employee(FirstName,LastName,Email,AddressID) values(@FirstName,@LastName,@Email,@AddressID);
end;
exec dbo.CreateEmployeeWithAddress 'Moni','Sharma','moni@example.com','Gandhi','mumbai','maharashtra','23167';


create procedure DeleteEmployee
@EmployeeID int
as
begin
declare @AddressId int;
--start transaction
begin transaction;
--get the addressid for rollback purposes
select @AddressId=AddressId from Employee where EmployeeId=@EmployeeID;
--delete the employees record
delete from Employee where EmployeeId=@EmployeeID;
--delete the address record
delete from address where AddressId=@AddressId;
--commit transaction
Commit transaction;
end;
exec dbo.DeleteEmployee 3;

create procedure GetAllEmployees
as
begin
select e.EmployeeId,e.FirstName,e.LastName,e.Email,a.Street,a.City,a.State,a.PostalCode
from Employee e
inner join Address a on e.AddressId=a.AddressId;
End
exec dbo.GetAllEmployees

create procedure GetEmployeeById
@EmployeeId int
as
begin
select e.EmployeeId,e.FirstName,e.LastName,e.Email,a.Street,a.City,a.State,a.PostalCode
from Employee e
inner join Address a on e.AddressId=a.AddressId
where e.EmployeeId=@EmployeeId
End
exec dbo.GetEmployeeById 4


create procedure UpdateEmployeeWithAddress
@EmployeeId int,
@FirstName varchar(100),
@LastName varchar(100),
@Email varchar(100),
@Street varchar(255),
@City varchar(100),
@State varchar(100),
@PostalCode varchar(20),
@AddressId int
as
begin
update Address set Street = @Street, City=@City, State=@State,PostalCode=@PostalCode where AddressId=@AddressId;
update Employee set FirstName= @FirstName, LastName=@LastName, Email=@Email, AddressId=@AddressId
where EmployeeId=@EmployeeId;
end;
exec UpdateEmployeeWithAddress 2,'Romi','Jain','romijain@example.com','MG Road','Chandigarh','Chandigarh','34789',2;
