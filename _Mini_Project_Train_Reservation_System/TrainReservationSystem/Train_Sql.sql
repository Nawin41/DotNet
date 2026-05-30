create database TrainDB;
use TrainDB;

create table Trains (
    TrainNo int primary key,
    Name nvarchar(100),
    FromStation nvarchar(50),
    ToStation nvarchar(50),
    Class nvarchar(20),
    Availability int,
    Charges int,
    IsDeleted bit default 0
);

create table Booking (
    BookingId int identity primary key,
    BookDate datetime,
    TravelDate datetime,
    TrainNo int,
    TravelClass nvarchar(20),
    Passengers int,
    Amount int
);

create table Cancellation (
    CId int identity primary key,
    BookingId int,
    NoTickets int,
    Refund int
);

select * from Cancellation;
select * from Trains;
select * from Booking;
