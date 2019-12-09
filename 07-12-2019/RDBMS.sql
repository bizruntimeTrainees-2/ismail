
/*DBMS database Management System*/
create table Employee
(
ID int , Emp_name varchar(50), Emp_Designation varchar(5)
)
insert into Employee values(1, 'Programmer','C#')

/*RDBMS Relational Database Management System*/
create table Student
(
Std_id int primary key identity(1,1), std_Name varchar(50),std_Country varchar(50)
)
insert into Student values('Programmer','C#')
insert into Student values('Developer','Java')

delete from Student where Std_id = 2
select * from Student

create table Car(Car_id int primary key identity(1,1), Car_Name varchar(50))
insert into Car values('BMW'),('Audi'),('Farrari')

create table Registration(R_id int primary key identity(1,1), Registration varchar(50),
Car_reg_id  int  foreign key references Car(Car_id))
insert into Registration values('AUK-2555',1)

select * from Car
select * from Registration

