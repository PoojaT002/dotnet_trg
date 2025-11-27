--create database infinitedb
create table students
(
studentid int,
studentname varchar(20),
age int,
saddress varchar(20)
)
select*from students
insert into students values
(101,'Pooja',23,'Sedam'),
(102,'Pree',19,'sedam')
drop table students
create table studentstbl
(studentid int,studentname varchar(20),age int,saddress varchar(20)
)
select*from studentstbl
insert into studentstbl(studentid,studentname,age,saddress)values(101,'pooja',23,'sedam'),(102,'pree',19,'glb'),(103,'Amit',25,'sedam'),(104,'sonu',24,'hyd')
delete from studentstbl where studentid=101
select*from studentstbl where age>22
select*from studentstbl order by studentname asc,age desc


