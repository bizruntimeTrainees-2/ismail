drop table Employee

create table Employee
(
Emp_id int primary key identity(1,1), Emp_Name varchar(50),Salary int
)
insert into Employee values('Raju',5000)

create trigger msg
on Employee for insert 
as
begin
print 'ur record has been in the database'
end

alter trigger msg
on Employee for insert 
as
if(select Salary from inserted) > 5000
begin
print 'ur Amount Exceeded'
end
else
begin
print 'ur Amount has been Processed'
end

insert into Employee values('Raju',5000)
insert into Employee values('Ramesh',6000)

alter trigger msg
on Employee for insert 
as
if(select Salary from inserted) > 5000
begin
print 'ur Amount Exceeded'
rollback transaction
end
else
begin
print 'ur Amount has been Processed'
end

select * from Employee

insert into Employee values('Venu',6000)
insert into Employee values('Gopal',4000)
insert into Employee values('Ramu',6000)
insert into Employee values('Ramu',2000)

drop trigger msg 