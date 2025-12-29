create table tblProducts
(
ID int identity primary key,
pname nvarchar(20),
description nvarchar(50)
)

insert into tblProducts values('Desktops','Intel'),
('iPhones','Apple Ltd'),
('Led TV','Sony')

select*from tblProducts

create or alter procedure spProductsDetails
as
begin 
waitfor delay '00:00:05'
select Id,pname,description from tblProducts
end
 
exec spProductsDetails
 
 
create or alter procedure spGetProductByName
@Productname nvarchar(50)
as
begin
if(@Productname = 'All')
begin
select Id,pname,description from tblproducts
end
else
begin
select Id,pname,description from tblproducts where pname=@Productname
end
end
 
exec spGetProductByName 'laptops'
