IF DB_ID('PanPizza') IS NULL
    create database PanPizza;
GO	
use PanPizza
--Deleting tables and views, if they exist
IF OBJECT_ID('dbo.tblPizza') IS NOT NULL DROP TABLE dbo.tblPizza;
IF OBJECT_ID('dbo.vwPizza') IS NOT NULL DROP VIEW dbo.vwPizza;
GO
create table tblPizza(
PizzaId int identity(1,1) PRIMARY KEY,
PizzaSize varchar(50) NOT NULL,
PizzaIngredients nvarchar(255) NOT NULL,
TotalAmount int NOT NULL,
);
GO
create view vwPizza as
select *
from tblPizza;