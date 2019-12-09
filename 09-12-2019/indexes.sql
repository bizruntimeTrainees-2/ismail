select * from Employee


create index IX_Employee_Salary
on employee (Salary asc)

drop index Employee.IX_Employee_Salary

create  table dbo.PhoneBook
(
LastName varchar(50) not null,
firstName varchar(50)not null,
phoneNumber varchar(50)  not null
)
-- for clustered index 
create Clustered index firstName_index on dbo.PhoneBook (firstName)

SELECT 
    SOUNDEX('Two') soundex_two,
    SOUNDEX('Too') soundex_too,
    DIFFERENCE('Two', 'Too') similarity;

SELECT 
   TRIM('    TRIM Function ')result;

   SELECT 
    value  
FROM 
    STRING_SPLIT('red,green ,blue', ',');

	CREATE TABLE products.parts(
    part_id   INT NOT NULL, 
    part_name VARCHAR(100)
);

INSERT INTO 
    products.parts(part_id, part_name)
VALUES
    (1,'Frame'),
    (2,'Head Tube'),
    (3,'Handlebar Grip'),
    (4,'Shock Absorber'),
    (5,'Fork');

SELECT 
    part_id, 
    part_name
FROM 
    products.parts
WHERE 
    part_id = 5;

	
drop table products.part_prices
CREATE TABLE products.part_prices(
    part_id int,
    valid_from date,
    price decimal(18,4) not null,
    PRIMARY KEY(part_id, valid_from) 
);


ALTER TABLE products.parts
ADD PRIMARY KEY(part_id);


CREATE CLUSTERED INDEX ix_parts_id
ON products.parts (part_id); 



CREATE CLUSTERED INDEX index_name
ON  products.part_prices(part_id); 


select * from Employee
create index indexe 
on Employee(Emp_id)

select Emp_Name from Employee where Emp_id = 4

create index  Employee_ID on   Employee(Emp_Name)

select * from Employees
-- for clustered index 
create Clustered index Employees_ID on Employees (Employee_Name)