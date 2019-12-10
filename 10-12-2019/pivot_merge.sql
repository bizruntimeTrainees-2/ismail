
select * from Employee
delete  from  Employee where Emp_id = 5

--PIVOT 
DECLARE 
@columns nvarchar(max) = '',
@sql nvarchar(max) = '';
--select employee name
SELECT 
     @columns += QUOTENAME(Emp_Name) +','
FROM  Employee
ORDER BY 
   Emp_Name

   --remove the last camma
SET @columns = LEFT(@columns, LEN(@columns)-1);

--construct dynamic sql
SET @sql = '
SELECT * FROM
(
SELECT  
     Emp_Name,
	 Emp_id,
	 Salary
  FROM
     Employee
	 )t
	 PIVOT(
	 COUNT(Emp_id)
	 FOR Emp_Name in ('+@columns+')
	) as pivot_tabe;';
	 
--execute the dynamic sql
EXECUTE  sp_executesql @sql;

--merge 
CREATE TABLE products.category (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(255) NOT NULL,
    amount DECIMAL(10 , 2 )
);
 INSERT INTO products.category(category_id, category_name, amount)
VALUES(1,'Children Bicycles',15000),
    (2,'Comfort Bicycles',25000),
    (3,'Cruisers Bicycles',13000),
    (4,'Cyclocross Bicycles',10000);

CREATE TABLE products.category_staging (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(255) NOT NULL,
    amount DECIMAL(10 , 2 )
);
 
 
INSERT INTO products.category_staging(category_id, category_name, amount)
VALUES(1,'Children Bicycles',15000),
    (3,'Cruisers Bicycles',13000),
    (4,'Cyclocross Bicycles',20000),
    (5,'Electric Bikes',10000),
    (6,'Mountain Bikes',10000);

	select * from products.category
	select * from products.category_staging


  MERGE products.category t 
    USING products.category_staging s
ON (s.category_id = t.category_id)
WHEN MATCHED
    THEN UPDATE SET 
        t.category_name = s.category_name,
        t.amount = s.amount
WHEN NOT MATCHED BY TARGET 
    THEN INSERT (category_id, category_name, amount)
         VALUES (s.category_id, s.category_name, s.amount)
WHEN NOT MATCHED BY SOURCE 
    THEN DELETE;



	select  * from  products.category 

	alter table  products.category add  ct_year  INT 

	update products.category set  ct_year= 2019
	alter table  products.category DROP COLUMN ct_year  
	