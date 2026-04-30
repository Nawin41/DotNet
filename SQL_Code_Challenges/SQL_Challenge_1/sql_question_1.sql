--use SQL_challenge_1;

--1.Write a query to fetch the details of the books written by author whose name ends with er. 

/*
create table books (
id int primary key,
title varchar(100),
author varchar(100),
isbn bigint unique,
published_date datetime
);

insert into books values
(1,'my first sql book','mary parker',981483029127,'2012-02-22 12:08:17'),
(2,'my second sql book','john mayer',857300923713,'1972-07-03 09:22:45'),
(3,'my third sql book','cary flint',523120967812,'2015-10-18 14:05:44');

*/

select * from books where author like '%er';