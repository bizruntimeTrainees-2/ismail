create schema products;
go

SELECT 
    s.name AS schema_name, 
    u.name AS schema_owner
FROM 
    sys.schemas s
INNER JOIN sys.sysusers u ON u.uid = s.principal_id
ORDER BY 
    s.name;



	CREATE TABLE dbo.Offices(
	office_id int primary key not null,
	office_name NVARCHAR(40) NOT NULL,
	office_add NVARCHAR(250) NOT NULL,
	phone NVARCHAR(20)
	);

	INSERT INTO dbo.Offices(office_id, office_name, office_add)
	 VALUES(101,'BIZRUNTIME', 'BESIDE OF MORIEE GATE,SARJAPURA MAIN ROAD')

	
	ALTER SCHEMA	products TRANSFER OBJECT:: dbo.offices;

	select * from dbo.offices;


	CREATE SCHEMA	hr;

	CREATE TABLE hr.person (
	person_id INT IDENTITY(1,1)  PRIMARY KEY,
	first_name  NVARCHAR(50) NOT NULL,
	last_name  NVARCHAR(50) NOT NULL,
	gender CHAR(6) NOT NULL);
	
	INSERT INTO hr.person (first_name, last_name, gender) 
	 OUTPUT inserted.person_id
	 VALUES('RAJU', 'm', 'MALE')
	 INSERT INTO hr.person (first_name, last_name, gender) 
	 OUTPUT inserted.person_id
	 VALUES('MAHESH', 'V', 'MALE')
	 INSERT INTO hr.person (first_name, last_name, gender) 
	 OUTPUT inserted.person_id
	 VALUES('RANI', 'R', 'FEMALE')

	 SELECT * FROM HR.person;

	 CREATE SEQUENCE item_counter
	 AS INT
	  START WITH 10
	   INCREMENT BY 10;

	   SELECT NEXT VALUE FOR item_counter;
	   SELECT NEXT VALUE FOR item_counter;

	  CREATE SCHEMA procurement;
	  GO

	  CREATE TABLE procurement.purchase_orders(
	  order_id INT PRIMARY KEY,
	  vender_id int NOT NULL,
	  order_date date NOT NULL);

	  CREATE SEQUENCE procurement.order_number
	  AS INT 
	  START WITH 1 INCREMENT BY 1;

	  INSERT INTO procurement.purchase_orders(
	  order_id, vender_id, order_date)
	  VALUES (NEXT VALUE FOR procurement.order_number,
	          1,'06-12-2019');
     INSERT INTO procurement.purchase_orders(
	  order_id, vender_id, order_date)
	  VALUES (NEXT VALUE FOR procurement.order_number,
	          3,'05-12-2019');

    select order_id,vender_id, order_date from procurement.purchase_orders;

	CREATE SEQUENCE procurement.receipt_no
	START WITH 1 INCREMENT BY 1;

	CREATE TABLE procurement.goods_receipts
	(
	receipt_id int primary key DEFAULT (NEXT VALUE FOR procurement.receipt_no),
	order_id int not null,
	full_receipt bit not null,
	receipt_date date not null,
	note NVARCHAR(100)
	);
	CREATE TABLE procurement.invoice_receipts
	(
	receipt_id int primary key DEFAULT (NEXT VALUE FOR procurement.receipt_no),
	order_id int not null,
	is_late  bit not null,
	receipt_date date not null,
	note NVARCHAR(100)
	);

	CREATE TABLE dbo.products(
	 product_no  INT IDENTITY PRIMARY KEY,
	 price int not null,
	 valid_to Date NOT NULL
	 );

	 select * from dbo.products;

	 ALTER TABLE dbo.products
	 ADD product_name varchar(250) not null;

	 ALTER TABLE dbo.products ALTER COLUMN product_name VARCHAR(50) not null;

	 ALTER TABLE  dbo.products DROP COLUMN product_name;

	  select * from dbo.products;