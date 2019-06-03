--Tasks:
--В базе данных MS SQL Server есть продукты и категории. 
--Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
--Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
--Если у продукта нет категорий, то его имя все равно должно выводиться.

--Create tables:
create table Product (
	Id						[int] identity(1,1) not null,
	ProductName				[varchar](1000) null,
	ProductByCategoryId		[varchar](1000) null,
	ProductId				[varchar](1000) null
)
go

create table Category (
	Id						[int] identity(1,1) not null,
	CategoryName			[varchar](1000) null,
	CategoryByProductId		[varchar](1000) null,
	CategoryId				[varchar](1000) null
)
go

insert into Product (ProductName, ProductByCategoryId, ProductId)
values 
('name1', '1', '1'),
('name2', '1', '2'),
('name3', '1', '3'),
('name4', '2', '4'),
('name5', '2', '5'),
('name6', '2', '6'),
('name7', '3', '7'),
('name8', '4', '8'),
('name9', '5', '9'),
('name0', '6', '0')
go

insert into Category (CategoryName, CategoryByProductId, CategoryId)
values 
('cat1', '1', '1'),
('cat2', '1', '2'),
('cat3', '1', '3'),
('cat4', '7', '4'),
('cat5', '7', '5'),
('cat6', '8', '6'),
('cat7', '0', '7'),
('cat8', '9', '8'),
('cat9', '2', '9'),
('cat0', '2', '0')
go

--SQL Source:
select p1.ProductName, c1.CategoryName
from Product as p1 with(nolock)
left join Category as c1 with(nolock) on p1.ProductByCategoryId = c1.CategoryId 
union
select p2.ProductName, c2.CategoryName
from Category as c2 with(nolock)
left join Product as p2 with(nolock) on c2.CategoryByProductId = p2.ProductId