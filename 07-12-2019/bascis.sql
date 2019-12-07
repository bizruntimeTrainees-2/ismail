CREATE SCHEMA  sales
GO


CREATE TABLE sales.stores (
 store_id INT IDENTITY (1, 1) PRIMARY KEY,
 store_name VARCHAR (255) NOT NULL,
 phone VARCHAR (25),
 email VARCHAR (255),
 street VARCHAR (255),
 city VARCHAR (255),
 state VARCHAR (10),
);


CREATE TABLE sales.staffs (
 staff_id INT IDENTITY (1, 1) PRIMARY KEY,
 first_name VARCHAR (50) NOT NULL,
 last_name VARCHAR (50) NOT NULL,
 email VARCHAR (255) NOT NULL UNIQUE,
 phone VARCHAR (25),
 active tinyint NOT NULL,
 store_id INT NOT NULL,
 manager_id INT,
 FOREIGN KEY (store_id) 
        REFERENCES sales.stores (store_id) 
 FOREIGN KEY (manager_id) 
        REFERENCES sales.staffs (staff_id) 
);

CREATE TABLE production.categories (
 category_id INT IDENTITY (1, 1) PRIMARY KEY,
 category_name VARCHAR (255) NOT NULL
);


CREATE TABLE production.brands (
 brand_id INT IDENTITY (1, 1) PRIMARY KEY,
 brand_name VARCHAR (255) NOT NULL
);

CREATE TABLE production.products (
 product_id INT IDENTITY (1, 1) PRIMARY KEY,
 product_name VARCHAR (255) NOT NULL,
 brand_id INT NOT NULL,
 category_id INT NOT NULL,
 model_year SMALLINT NOT NULL,
 list_price DECIMAL (10, 2) NOT NULL,
 FOREIGN KEY (category_id) 
        REFERENCES production.categories (category_id) 
 FOREIGN KEY (brand_id) 
        REFERENCES sales.brands (brand_id) 
);


CREATE TABLE sales.customers (
 customer_id INT IDENTITY (1, 1) PRIMARY KEY,
 first_name VARCHAR (255) NOT NULL,
 last_name VARCHAR (255) NOT NULL,
 phone VARCHAR (25),
 email VARCHAR (255) NOT NULL,
 street VARCHAR (255),
 city VARCHAR (50),
 state VARCHAR (25),
 zip_code VARCHAR (5)
);

CREATE TABLE sales.orders (
 order_id INT IDENTITY (1, 1) PRIMARY KEY,
 customer_id INT,
 order_status tinyint NOT NULL,
 order_date DATE NOT NULL,
 required_date DATE NOT NULL,
 shipped_date DATE,
 store_id INT NOT NULL,
 staff_id INT NOT NULL,
 FOREIGN KEY (customer_id) 
        REFERENCES sales.customers (customer_id) 
 FOREIGN KEY (store_id) 
        REFERENCES sales.stores (store_id) 
 FOREIGN KEY (staff_id) 
        REFERENCES sales.staffs (staff_id) 
);

CREATE TABLE sales.order_items(
 order_id INT,
 item_id INT,
 product_id INT NOT NULL,
 quantity INT NOT NULL,
 list_price DECIMAL (10, 2) NOT NULL,
 discount DECIMAL (4, 2) NOT NULL DEFAULT 0,
 PRIMARY KEY (order_id, item_id),
 FOREIGN KEY (order_id) 
        REFERENCES sales.orders (order_id) 
 FOREIGN KEY (product_id) 
        REFERENCES production.products (product_id) 
);

CREATE TABLE production.stocks (
 store_id INT,
 product_id INT,
 quantity INT,
 PRIMARY KEY (store_id, product_id),
 FOREIGN KEY (store_id) 
        REFERENCES sales.stores (store_id) 
 FOREIGN KEY (product_id) 
        REFERENCES production.products (product_id) 
);


SELECT AVG(list_price) avg_product_price FROM production.products;
SELECT CAST(ROUND(AVG(list_price),2) AS DEC (10, 2));

SELECT  MIN(list_price) min_list_price FROM production.products;
SELECT  MAX(list_price) max_list_price FROM production.products;

SELECT CAST(ROUND(STDEV(list_price),2) as DEC(10,2)) stdev_list_price FROM   production.products;

	SELECT
    category_id,
    AVG (list_price) avg_list_price
FROM
    production.products
GROUP BY
    category_id
HAVING
    AVG (list_price) BETWEEN 500 AND 1000;

	CREATE TABLE sales.sales_summary(product_id INT NOT NULL ,brand_name INT NOT NULL , category_name NVARCHAR(50), model_year INT );

SELECT
    GROUPING(brand) grouping_brand,
    GROUPING(category) grouping_category,
    brand,
    category,
    SUM (sales) sales
FROM
    sales.sales_summary
GROUP BY
    GROUPING SETS (
        (brand, category),
        (brand),
        (category),
        ()
    )
ORDER BY
    brand,
    category;



	SELECT
    d1,
    d2,
    d3,
    aggregate_function (c4)
FROM
    table_name
GROUP BY
    CUBE (d1, d2, d3); 


	SELECT
    d1,
    d2,
    d3,
    aggregate_function (c4)
FROM
    table_name
GROUP BY
    ROLLUP (d1, d2, d3);


	SELECT
    product_name,
    list_price
FROM
    production.products
WHERE
    product_id = ANY (
        SELECT
            product_id
        FROM
            sales.order_items
        WHERE
            quantity >= 2
    )
ORDER BY
    product_name;


	SELECT
    product_name,
    list_price
FROM
    production.products
WHERE
    product_id = ALL (
        SELECT
            product_id
        FROM
            sales.order_items
        WHERE
            quantity >= 2
    )
ORDER BY
    product_name;


	SELECT 
    first_name,
    last_name
FROM
    sales.staffs
UNION
SELECT
    first_name,
    last_name
FROM
    sales.customers;


	SELECT 
    first_name,
    last_name
FROM
    sales.staffs
UNION ALL 
SELECT
    first_name,
    last_name
FROM
    sales.customers;

	SELECT
    city
FROM
    sales.customers
INTERSECT
SELECT
    city
FROM
    sales.stores
ORDER BY
    city;



	CREATE VIEW sales.product_info
AS
SELECT
    product_name, 
    brand_name, 
    list_price
FROM
    production.products p
INNER JOIN production.brands b 
        ON b.brand_id = p.brand_id;