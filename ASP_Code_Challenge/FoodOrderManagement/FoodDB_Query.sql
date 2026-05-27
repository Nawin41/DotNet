CREATE DATABASE FoodOrderDB;
USE FoodOrderDB;

CREATE TABLE MenuItems (
    MenuId INT IDENTITY(1,1) PRIMARY KEY,
    ItemName NVARCHAR(100),
    Category NVARCHAR(50),
    Price INT,
    CreatedDate DATETIME DEFAULT GETDATE()
);
select * from MenuItems;