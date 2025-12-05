--5.Isolation Level – Dirty Read
--Use two sessions:
--• Session 1: Open a transaction, update a row, but don’t commit
--• Session 2: Use SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED and read the same row
--Check whether dirty reads are allowed

--session2

begin transaction

update customers
set age = 99
where custid = 101

select*from customers


--6. Isolation Level – Non-repeatable Read
--Using two sessions:

--• Session 2 updates and commits the same row in between
--Observe changes and understand non-repeatable reads.

begin transaction
update customers
set age = 40
where custid = 10;

commit;


--7. Isolation Level – Phantom Read
--Create a table Sales. Using two sessions:

--• Session 2

-- insert a new row that falls into the same range (a phantom)
begin transaction

insert into sales (SaleId,empid, region, SaleAmount, saledate)
values (6,6, 'north', 95000, getdate());

commit;