select * from tblStudent;

drop table if exists tblStudent ;
create table tblStudent(std_id int, std_name varchar(50), branch varchar(50))
insert into tblStudent (std_id,std_name,branch) values (1,'ramu','ece')
insert into tblStudent (std_id,std_name,branch) values (2,'rani','ece')
insert into tblStudent (std_id,std_name,branch) values (3,'akhil','civil')
insert into tblStudent (std_id,std_name,branch) values (4,'ajay','mec')
insert into tblStudent (std_id,std_name,branch) values (5,'raju','cse')
insert into tblStudent (std_id,std_name,branch) values (6,'soniya','cse')
insert into tblStudent (std_id,std_name,branch) values (7,'sumanth','mec')


select COUNT(*) from tblStudent
select std_id,std_name from tblStudent where branch ='ece';
select std_id,std_name from tblStudent where branch ='ece' order by std_id desc

select std_id,std_name from tblStudent  
order by std_id OFFSET 2 ROWS FETCH NEXT 15 ROWS ONLY;

update tblStudent
 set branch = 'ece'
 
 
 select distinct branch from tblStudent ;

 select * from tblStudent where std_name like 'r%' ;
 select top 2 std_name, std_id from tblStudent where std_name like 'r%' ;

 select std_name +' '+ branch as columnAlias from tblStudent order by std_id;
 drop table  tblCollege1;
 drop table  tblCollege2;

 create table tblCollege1(college_id int not null    primary key, std_Name nvarchar(50), course varchar(50) ,std_id  int)

 
 
 create table tblCollege2(college_id int not null   primary key, std_Name nvarchar(50), course varchar(50) ,std_id  int not null,
   constraint fk_clg_id  foreign key (college_id) references tblCollege2(college_id));
insert into  tblCollege1 (college_id , std_Name,course,std_id) values(1, 'a','C', 1)
insert into  tblCollege1 (college_id , std_Name,course,std_id) values(2, 'b','java', 2)
insert into  tblCollege1 (college_id , std_Name,course,std_id) values(3, 'c','C++', 3)
insert into  tblCollege1 (college_id , std_Name,course,std_id) values(4, 'd', 'c++',4)

insert into  tblCollege2 (college_id , std_Name,course,std_id) values(5, 'x','.net', 10)
insert into  tblCollege2 (college_id , std_Name,course,std_id) values(6, 'y','angular', 20)
insert into  tblCollege2 (college_id , std_Name,course,std_id) values(7, 'z','C', 30)
insert into  tblCollege2 (college_id , std_Name,course,std_id) values(8, 'xx', 'c++',40)

select c2.std_Name from tblCollege2 as c2 inner join tblCollege1 as c1 on c2.course = c1.course
select c2.std_Name from tblCollege2 as c2 left join tblCollege1 as c1 on c2.course = c1.course
select c1.std_Name from tblCollege2 as c2 right join tblCollege1 as c1 on c2.course = c1.course
select c1.std_Name, c1.course from tblCollege2 as c2 full outer join tblCollege1 as c1 on c2.course = c1.course
select c1.std_Name, c1.course from tblCollege1 as c2  inner join tblCollege1 as c1 on c2.course = c1.course
select c1.std_Name, c1.course from tblCollege1 as c2  inner join tblCollege1 as c1 on c2.course = c1.course

select c1.std_Name, c1.course from tblCollege2 as c2  cross join tblCollege1 as c1 

CREATE SCHEMA store;
Go
select USER_NAME  
from sys.all_columns

 
