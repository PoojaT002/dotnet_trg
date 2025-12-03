--Stored Procedure Assignment

--1. Create a procedure which accepts input parameter and inserts the data in the customer table.

create procedure spInput(@custid int,@custname varchar(50),@age int,@caddress varchar(50), @cphone varchar(10))
as
insert INTO customers(custid, custname, age, custAddress, custPhone)
    VALUES(@custid, @custname, @age, @caddress, @cphone)

spInput 101,'Asha',24,'Kolkatta','897564756'
select * from customers

--2. Create a procedure for orders table , which displays all the purchase made between 1-12-2005 and 2-12-2007
--(Accept date as parameter_)

create procedure OrdersBetweenDates(@StartDate date,@EndDate date)
as
begin
    select *from Orders
    where orderdate between @startdate and @enddate
end

drop procedure OrdersBetweenDates

OrdersBetweenDates '2019-12-22','2025-02-20'

--3. create a procedure which reads custid as parameter
--and return qty and produtid as output parameter

create table [Order] (
    OrderID int identity(1,1) primary key,
    CustID int,
    ProductID int,
    Qty int,
    OrderDate date,
    
    constraint FK_Orders_Products
        foreign key (ProductID)
        references Products(pid)
)


insert into [Order] (CustID, ProductID, Qty, OrderDate)
values
(101, 101, 5, '2024-09-12'),
(102, 102, 5, '2025-12-15'),
(103, 101, 2, '2024-07-02'),
(101, 102, 1, '2024-04-05'),
(104, 101, 10, '2025-03-25');

drop table [Order]

create procedure spOrderDetails
    @CustID int,
    @Qty int output,
    @ProductID int output
as
select
    @Qty = Qty,
    @ProductID = ProductID
    from [Order]
    where CustID = @CustID

declare @p int
declare @q int
exec spOrderDetails 107,@p output,@q output
print @p
print @q

drop procedure spOrderDetails

--4. Write a batch that will check for the existence of the productname 
--“books” if it exists, display the total stock of the book else print 
--“productname books not found”.

create procedure productCheck(@book varchar(20))
as
if exists (select * from products where pname = @book)
begin
select sum(stock) as TotalStock
from products
where pname = 'books'
end
else
begin
print 'productname books not found'
end

productCheck 'books'

alter table products add stock int

--5.insert data to customer table via return value of sp_getdata() procedure

create procedure spgetdata
as
begin
    declare @id int
    set @id = 501
    return @id
end

declare @custid int
exec @custid = spgetdata;
insert into customers(custid, custname,age,custAddress,custphone)
values (@custid,'Ram',25,'Delhi','28945369')
select*from customers

--6. Create a procedure to display all customer details 
--where rownumber between 2 to 5 (accept row number as a parameter)

create procedure spcustomerdetails(@startrow int,@endrow int)
as begin with c as 
(
 select *, row_number() over(order by custid) as rn from customers
)
select *from c where rn between @startrow and @endrow
end

exec spcustomerdetails 3,8

--7.Create a stored procedure to insert a new employee
--Create a table Employees and write a stored procedure:
--• Procedure name: spAddEmployee
--• Inputs: Name, Department, Salary
--• Insert the record into Employees table.
--• Return newly generated CustomerID using SCOPE_IDENTITY().

drop procedure spaddEmployee

create procedure spaddEmployee
    @name varchar(50),
    @department varchar(50),
    @salary decimal(10,2)
as
    insert into newemployeestbl (ename, department, salary)
    values (@name, @department, @salary);
    return scope_identity()

declare @res int
exec @res = spAddEmployee 'Prita','IT', 960000 
print @res

insert into newemployeestbl (ename, department, salary) values
('soni', 'sales', 65000),
('Ravi', 'IT', 50000),
('Somesh', 'HR', 45000),
('Sonal', 'marketing', 42000),
('karan', 'finance', 48000)

select*from newemployeestbl


create table newemployeestbl (
    empid int identity(1,1) primary key,
    ename varchar(50),
    department varchar(50),
    salary decimal(10,2)
)
drop table newemployeestbl


--8.Create a stored procedure with default parameter
--Create spGetProductsByCategory
--• Parameter: CategoryName (default should be ‘Electronics’)
--• Return all products of that category.
--• Create Procedure WITH ENCRYPTION

alter table products
add categoryname varchar(50) default 'electronics'

create procedure spproductbycategory
@categoryname varchar(50) = 'electronics'
with encryption
as
select * from products where categoryname = @categoryname
exec spproductbycategory

drop procedure spproductbycategory


--9. Stored procedure using TRY…CATCH
--Create spSafeOrderInsert
--• Insert a new order
--• If any error occurs, insert error details into an ErrorLog table

create table ErrorLogs
(
ErrorId int identity primary key,
ErrorMessage varchar(max),
ErrorTime Datetime default GetDate()
)
 
create procedure spSafeOrderInsert
@custID int,
@orderId int,
@Price money,
@Qty int
as
begin Try
insert into Orders(custId,orderId,orderDate,price,quantity)
values (@custID,@orderId,GetDate(),@Price,@Qty)
end try
begin catch
insert into ErrorLogs(ErrorMessage)
values(Error_message())
end catch

exec spSafeOrderInsert
@custID=101,
@orderId=60000,
@Price=500,
@Qty=3
 
exec spSafeOrderInsert 102,60001,750,4
 
select * from Orders where orderId=60001
 
exec spSafeOrderInsert 999,54729,800,5
 
displayData 'ErrorLogs'
 
exec spSafeOrderInsert 101, Null, 500, 2

drop procedure spSafeOrderInsert


--10.Stored procedure with multiple operations
--Create spUpdateSalary
--• Inputs: EmpID, Percentage
--• Increase employee salary by given percentage
--• Return updated salary

create procedure spUpdateSalary
@empId int,
@percentage float
as
begin
 
update Employee 
set salary = salary +(salary * (@percentage/100))
where EmpID = @empId
 
select salary as UpdateSalary 
from Employee
where EmpId =@empId
end
 
exec spUpdateSalary
@empId=1,
@percentage=10
 
spUpdateSalary 2,20
 
displayData 'Employee'
go
displayData 'ErrorLogs'



