create  schema  sales;


CREATE TABLE sales.brand(
    brand_id INT IDENTITY PRIMARY KEY,
    brand_name VARCHAR(255) NOT NULL
);

insert into sales.brands values('jockey'),('pune'),('paragon')

CREATE TABLE sales.brand_approvals(
    brand_id INT IDENTITY PRIMARY KEY,
    brand_name VARCHAR(255) NOT NULL
);



CREATE  VIEW   sales.vw_brand
AS
SELECT
    brand_name,
    'Approved' approval_status
FROM
    sales.brand
UNION
SELECT
    brand_name,
    'Pending Approval' approval_status
FROM
    sales.brand_approvals;


CREATE TRIGGER  sales.trg_vw_brand
	ON  sales.vw_brand
	INSTEAD OF INSERT
	AS
	BEGIN 
	     SET NOCOUNT ON;
		 INSERT INTO     sales.brand_approvals( brand_name)

		 SELECT
		    i.brand_name
		  FROM
		  inserted i
		   WHERE
		     i.brand_name not in (
			 select brand_name
			 from
			  sales.brand
             );

		   END

INSERT INTO sales.vw_brand(brand_name)
VALUES('sports'),('rakh');

select * from sales.vw_brand