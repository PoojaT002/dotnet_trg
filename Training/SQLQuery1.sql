--view with encryption
-----------------------
create view v1
with encryption
as
select studentRollNumber, studentName,Class from Students 

select*from v1

--view with checkpoint
------------------------
create view v2
as
select StudentRollNumber, StudentName,Class from Students
where Class =10

select* from v2 

--view with schemabinding
-----------------------
create view v3
with schemabinding 
as 
select StudentRollNumber,StudentName,Class from dbo.Students

select*from v3

sp_helptext v2

sp_depends v1

create view v4
with encryption, schemabinding
as
select StudentRollNumber,StudentName,Class from dbo.Students
where Class = 10
with check option

select *from v4


write a querrt to find the sum of age and i want group by address