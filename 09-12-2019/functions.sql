drop table Employee

create table Employee
(
Emp_id int primary key identity(1,1), Emp_Name varchar(50),Salary int
)
insert into Employee values('Raju',5000)

insert into Employee values('Venu',6000)
insert into Employee values('Gopal',4000)
insert into Employee values('Ramu',6000)
insert into Employee values('Ramu',2000)

select * from Employee

select MAX(Salary) from Employee
select MIN(Salary) from Employee
select AVG(Salary) from Employee

select top 3(Emp_Name) from Employee

select DATALENGTH(Emp_Name) from Employee

select count(*) from Employee 

select UPPER(Emp_Name) from Employee

select LOWER(Emp_Name) from Employee

select * from Employee

select UPPER(
(select Emp_Name from Employee where Emp_id = 4) 
)
select LOWER(
(select Emp_Name from Employee where Emp_id = 4) 
)

--date functions
select GETDATE()
select SYSDATETIME()
select SYSTEM_USER
select YEAR(GETDATE())
select day(GETDATE())
select DATEPART(year,GETDATE())
select DATEPART(HOUR,GETDATE())

select SYSDATETIMEOFFSET()

--system functions
select CONVERT(int , 50.55) result;
select CAST(9.4 as DEC(2,0)) result;

select CHOOSE(2, 'first','second','third') result

select ISNULL(null,20) result
select ISNULL('raju','ramesh') result

select IIF(10 < 20,'true','false') result

select SUM(IIF(10> 20,1,0)) 'pending',
       SUM(IIF(10> 20,1,0)) 'processing',
	   SUM(IIF(10> 20,1,0)) 'rejected',
	   SUM(IIF(10> 20,1,0)) 'completed',
	   COUNT(*) total
from Employee
where YEAR(GETDATE()) = 2019

select TRY_PARSE('10 april 2019' as date) result

declare @dt DateTime = getDate();
select CONVERT(varchar(20),@dt, 0) s1,
       CONVERT(varchar(20),@dt, 100) s2


SELECT 
    CONVERT(DATETIME, '20190731 12:20:22 ') result;

	SELECT 
    TRY_CONVERT(DATETIME, '20190731 12:20') result;

	SELECT 
    CONVERT(DATE, GETDATE()) date;


	--windows functions
select CONCAT_WS('',Emp_Name,' Babu') full_name,
	       Salary,
		   DENSE_RANK() over(
		   order by Emp_Name ) my_rank
  from  Employee 
 

 select FIRST_VALUE(Emp_Name)
  over(
  order by Salary 
  ) as first_value
  
 from Employee
 where Salary < 10000

 select LAST_VALUE(Emp_Name)
  over(
  order by Salary 
  ) as last_value
  
 from Employee
 where Salary < 10000
	   select * from Employee