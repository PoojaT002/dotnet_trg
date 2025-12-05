--Demo-1

	DECLARE @Name VARCHAR(100)
	declare @sal int

DECLARE emp_cursor CURSOR FOR
SELECT cname, salary FROM test

OPEN emp_cursor

FETCH NEXT FROM emp_cursor INTO @Name,@sal
print @name 
print @sal
print @@fetch_status
FETCH NEXT FROM emp_cursor INTO @Name,@sal
print @name 
print @sal
print @@fetch_status
FETCH NEXT FROM emp_cursor INTO @Name,@sal
print @name 
print @sal
print @@fetch_status
FETCH NEXT FROM emp_cursor INTO @Name,@sal
print @name 
print @sal
print @@fetch_status
CLOSE emp_cursor
DEALLOCATE emp_cursor


--Demo-2
	DECLARE @Name VARCHAR(100)
	declare @sal int

DECLARE emp_cursor CURSOR FOR
SELECT cname , salary FROM test

OPEN emp_cursor


FETCH NEXT FROM emp_cursor INTO @Name, @sal
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'STATIC: ' + @Name +  '   '   + cast(@sal as varchar)
    FETCH NEXT FROM emp_cursor INTO @Name ,@sal
END

CLOSE emp_cursor
DEALLOCATE emp_cursor
--------------------------------------------------------


--demo-3(static cursor)


	DECLARE @Name VARCHAR(100)
	declare @sal int

DECLARE emp_cursor1 CURSOR static  FOR     --does not welcome new records

SELECT cname , salary FROM test

OPEN emp_cursor1
FETCH NEXT FROM emp_cursor1 INTO @Name, @sal
WHILE @@FETCH_STATUS = 0
BEGIN
 waitfor delay '00:00:5'
    PRINT 'STATIC: ' + @Name +  '   '   + cast(@sal as varchar)
    FETCH NEXT FROM emp_cursor1 INTO @Name ,@sal
END

CLOSE emp_cursor1
DEALLOCATE emp_cursor1

================================================================================================
--demo-4 (dynamic)



	DECLARE @Name VARCHAR(100)
	declare @sal int

DECLARE emp_cursor1 CURSOR static  FOR     --welcomes  new records(inserts)

SELECT cname , salary FROM test

OPEN emp_cursor1
FETCH NEXT FROM emp_cursor1 INTO @Name, @sal
WHILE @@FETCH_STATUS = 0
BEGIN
 waitfor delay '00:00:5'
    PRINT 'STATIC: ' + @Name +  '   '   + cast(@sal as varchar)
    FETCH NEXT FROM emp_cursor1 INTO @Name ,@sal
END

CLOSE emp_cursor1
DEALLOCATE emp_cursor1
=================================================================================================


--demo-5 (key set)

	DECLARE @Name VARCHAR(100)
	declare @sal int

DECLARE emp_cursor1 CURSOR keyset  FOR     -- works only with table having primary key
SELECT cname , salary FROM test

OPEN emp_cursor1
FETCH NEXT FROM emp_cursor1 INTO @Name, @sal
WHILE @@FETCH_STATUS = 0
BEGIN
 waitfor delay '00:00:5'
    PRINT 'STATIC: ' + @Name +  '   '   + cast(@sal as varchar)
    FETCH NEXT FROM emp_cursor1 INTO @Name ,@sal
END

CLOSE emp_cursor1
DEALLOCATE emp_cursor1

-- any changes for existing records allowed , rest not allowed
============================================================================================


scroll(every direction allowed , every changes are allowed)


DECLARE @Name VARCHAR(100)

DECLARE emp_cursor2 CURSOR SCROLL FOR
SELECT cname FROM test
OPEN emp_cursor2
-- First row
FETCH FIRST FROM emp_cursor2 INTO @Name
PRINT 'FIRST: ' + @Name
-- Last row
FETCH LAST FROM emp_cursor2 INTO @Name
PRINT 'LAST: ' + @Name
-- Previous row
FETCH PRIOR FROM emp_cursor2 INTO @Name
PRINT 'PRIOR: ' + @Name
CLOSE emp_cursor2
DEALLOCATE emp_cursor2

select * from test
==========================================================================


1. clustered (table will be sorted)
2.non clustered (not sort the table)

when u apply pk -> which index type is created?
clustered


how many clustured index can table have?
 1

how many nonclustured index can table have?
999


how do u apply index?

CREATE CLUSTERED INDEX CL_lastname
ON employees(lastname)


why to apply index?

making the query runs faster


when to apply clustered index?
when the query contains > < between  (less duplicate values)


when to apply nonclustered index?(more duplicate values)

when the query contains like , notin 





