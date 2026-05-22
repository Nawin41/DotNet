create database ASP_Assignment_DB;
use ASP_Assignment_DB;

create table Users 
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50),
    FamilyName NVARCHAR(50),
    Address NVARCHAR(100),
    City NVARCHAR(50),
    ZipCode NVARCHAR(10),
    Phone NVARCHAR(20),
    Email NVARCHAR(100)
);

create table Products 
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50),
    Price INT,
    ImagePath NVARCHAR(200)
);

insert into Products (Name, Price, ImagePath)
values ('Laptop', 50000, '~/Images/laptop.jpg');

insert into Products (Name, Price, ImagePath)
values ('Mobile', 20000, '~/Images/mobile.jpg');


insert into Products (Name, Price, ImagePath)
values 
('Headphones', 3000, '~/Images/headphones.jpg'),
('PlayStation', 45000, '~/Images/playstation.jpg');

