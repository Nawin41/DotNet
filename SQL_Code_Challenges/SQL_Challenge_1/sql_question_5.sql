use SQL_challenge_1;

--5.Write a query to display the   Date,Total no of customer  placed order on same Date

/*
create table orders (
oid int primary key,
date datetime,
customer_id int,
amount int);

insert into orders values
(102, '2009-10-08 00:00:00', 3, 3000),
(100, '2009-10-08 00:00:00', 3, 1500),
(101, '2009-11-20 00:00:00', 2, 1560),
(103, '2008-05-20 00:00:00', 4, 2060);*/

select date,count(distinct customer_id) as total_customers from orders
group by date;