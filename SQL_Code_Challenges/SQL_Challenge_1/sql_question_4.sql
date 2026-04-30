use SQL_challenge_1;

--4.Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address 

/*
create table customer(
id int primary key,
name varchar(50),
age int,
address varchar(50),
salary decimal(10,2)
);

insert into customer values
(1,'ramesh',32,'ahmedabad',2000.00),
(2,'khilan',25,'delhi',1500.00),
(3,'kaushik',23,'kota',2000.00),
(4,'chaitali',25,'mumbai',6500.00),
(5,'hardik', 27,'bhopal',8500.00),
(6,'komal', 22,'mp',4500.00),
(7,'muffy', 24,'indore',10000.00);
*/


select name from customer
where address like '%o%';