--inner join 
select*from customers inner join orders on customers.custid=orders.custid

--left outer join
select*from customers left outer join orders on customers.custid=orders.custid

--right outer join
select*from customers right outer join orders on customers.custid=orders.custid

--full join
select*from customers full outer join orders on customers.custid=orders.custid

--cross join
select*from customers cross join orders

--self join
select a.*from customers a,customers b where a.age> b.age and b.custname='Avyaansh'

--union
select*into customersnew from customers
select*from customers
select*from customers union select*from customersnew

--union all
select *from customers union all select*from customersnew 

--except
select*from customers except select * from customersnew

--intersect
select *from customers intersect select*from customersnew