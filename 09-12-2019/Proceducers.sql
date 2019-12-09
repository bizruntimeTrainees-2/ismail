drop table  Employee
create table Employee (
Emp_id int primary key identity(1,1),
Emp_Name varchar(50),
Emp_Desig varchar(50),
Salary int 
)
select * from Employee

--Insert Record StoreD Proceducer
create proc InsertProc 
(
@Emp_Name varchar(50),
@Emp_Desig varchar(50),
@Emp_Salary int
)
as begin
insert into Employee values(@Emp_Name,@Emp_Name,@Emp_Salary)
end

execute InsertProc 'Programmer','PHP',5000

--Update record
create proc UpdateProc 
(
@ID  int,
@Emp_Name varchar(50),
@Emp_Desig varchar(50),
@Emp_Salary int
)
as begin
update Employee set Emp_Name=@Emp_Name,Emp_Desig= @Emp_Desig,Salary=@Emp_Salary where Emp_id = @ID
end

execute UpdateProc 1,'WebDeveloper','C#',25000
select * from Employee

create proc Deleteproc 
(@ID  int)
as begin
delete from  Employee  where Emp_id = @ID
end
execute Deleteproc 2
select * from Employee

drop table States

drop table Province

drop table  Country

create table Country(Count_id int primary key identity(1,1),
Country_Name varchar(50))
create table Province(Prov_id int primary key identity(1,1),
Prov_Name varchar(50),Province_id int foreign key references Country(Count_id))
create table States(State_id int primary key identity(1,1),State_Name varchar(50),
Stat_id int foreign key references Province(Prov_id))

select * from Country
select * from States
select * from Province

create proc Stores
(
@CountryName varchar(50),
@ProvinceName varchar(50),
@StatesName varchar(50)
)
as 
begin
insert into Country values(@CountryName)
declare @ProvinceID int = @@identity
insert into Province values(@ProvinceName,@ProvinceID)
declare @CityID int = @@identity
insert into States values (@StatesName,@CityID)
end

exec Stores 'Chaina','Chaina','Chain'

