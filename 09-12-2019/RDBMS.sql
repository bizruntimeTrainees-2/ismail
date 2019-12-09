
create table Country(Count_id int primary key identity(1,1),
Country_Name varchar(50))
create table Province(Prov_id int primary key identity(1,1),
Prov_Name varchar(50),Province_id int foreign key references Country(Count_id))
create table States(State_id int primary key identity(1,1),State_Name varchar(50),
Stat_id int foreign key references Province(Prov_id))

insert into Country values ('USA')
insert into Province values ('USA',1)
insert into States values ('UK',1)
insert into Country values ('India')
insert into Province values ('India',2)
insert into States values ('India',2)

select  * from Country
select  * from Province
select  * from States





create table Students(Student_id int primary key identity(1,1), 
Student_Name varchar(50),
Student_roll varchar(50),
Con_id int foreign key references Country(Count_id),
Pro_id int foreign key references Province(Prov_id),
cty_id int foreign key references States(State_id))

select * from Students

insert into Students  values('Rajesh','1024',1,1,1)
insert into Students  values('Webdeveloper','1025',1,1,1)
insert into Students  values('Programmer','1026',2,2,2)

select Students.Student_id, Students.Student_Name,Students.Student_roll,
Country.Country_Name,Province.Prov_Name,States.State_Name
 from Students
 inner join Country on Students.Con_id = Country.Count_id
 inner join Province on Students.Pro_id =Province.Prov_id
 inner join States on Students.cty_id = States.Stat_id

 /*Constraints
 Primary key
 Foreign key
 Not null
 Unique
 check
 Default
 */

 --Unique
 create table Programming 
(
Id int primary key identity(1,1), Programming_Name varchar(50),Progm_id varchar(50) unique
)

insert into Programming values('Java',1010)
insert into Programming values('C#',1010)

select * from Programming

--Not null and Check
create table Employees 
(
Employee_id int primary key identity(1,1) not null,
Employee_Name varchar(50) not null,
Employee_Salary int check(Employee_Salary > 5000)
)
insert into Employees values('John', 4000)
insert into Employees values('John', 5000)
insert into Employees values('John', 6000)

drop table Employees


--Default
create table Employees 
(
Employee_id int primary key identity(1,1) not null,
Employee_Name varchar(50) not null,
Employee_Salary int default(5000) not null
)
insert into Employees values ('John', 2000)
insert into Employees values ('Rajesh', 4000,20000),
insert into Employees values ('Mahi', 6000,30000),('Raju', 8000,40000),('Biswa', 10000,50000)
select * from Employees

alter table Employees add Salary int default(10000) not null

select * from Employees where Employee_Salary between 2000 and 4000
select * from Employees where Salary>= 10000 and Salary<= 40000
select * from Employees where Salary in (10000,20000,30000)

select * from Employees

create view E_table
as 
select Employee_Name,Employee_Salary from Employees

select * from E_table

create view V_Table
as Select Employee_Name from E_table

select * from V_table

insert into V_Table values ('Sudheer')
update  V_Table set  Employee_Name='Raju' where Employee_Name ='Sudheer'
delete Employees where Employee_Name='Raju'

select * from V_table
drop view E_table