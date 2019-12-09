select SQUARE(5) as multiple

create function Products.addition(@a int, @b int)
returns int 
as 
begin
declare @result int = @a + @b
return @result
end

select Products.addition(10,10) as Addition

create function Products.multiplication(@a int, @b int)
returns int 
as 
begin
declare @result int = @a * @b
return @result
end


select Products.multiplication(10,10) as Multiplication

create function Products.division(@a int, @b int)
returns int 
as 
begin
declare @result int = @a % @b
return @result
end

select Products.division(10,10) as Division

alter function Products.division(@a int, @b int)
returns int 
as 
begin
declare @result int = @a / @b
return @result
end

select Products.division(10,10) as Division

drop function  Products.division
