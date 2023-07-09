--Select
--ANSII Oracle, Pstgre, MySql, SqlServer
--case insensitive
Select ContactName, CompanyName, City from Customers

Select * from Customers where city ='Berlin' 

Select * from Products where categoryId=1 or CategoryID=3

Select * from Products where categoryId=1 and UnitPrice>10

Select * from Products where categoryId=1 and UnitPrice>=15

Select * from Products where categoryId=1 and UnitPrice<>15

Select * from Products order by CategoryID, ProductName

Select * from Products order by UnitPrice asc --ascending artan  descending azalan düşen


Select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) Adet from products where CategoryID=2


select CategoryID, COUNT(*) from Products where UnitPrice>20 group by CategoryID having COUNT (*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on products.CategoryId= categories.CategoryId
where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID
select * from Products p left join [Order Details] od on p.ProductID=od.ProductID
select * from Customers c inner join Orders o on c.CustomerID=o.CustomerID --830 rows
select * from Customers c left join Orders o on c.CustomerID=o.CustomerID --832 rows

select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID inner join Orders o on o.OrderID= od.OrderID