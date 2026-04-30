use SQL_challenge_1;

--6.Display the Names of the Employee in lower case, whose salary is null

/*
create table employee(
id int primary key,
name varchar(50),
age int,
address varchar(50),
salary decimal(10,2));

insert into employee values
(1,'ramesh',32,'ahmedabad',2000.00),
(2,'khilan',25,'delhi',1500.00),
(3,'kaushik',23,'kota',2000.00),
(4,'chaitali',25,'mumbai',6500.00),
(5,'hardik',27,'bhopal',8500.00),
(6,'komal',22,'mp',null),
(7,'muffy',24,'indore',null);*/

select lower(name) as employee_name from employee where salary is null;