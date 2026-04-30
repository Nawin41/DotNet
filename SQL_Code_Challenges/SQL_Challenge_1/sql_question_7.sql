use SQL_challenge_1;

--7. Write a sql server query to display the Gender,Total no of male and female from the above relation
/*
create table studentdetails(
registerno int,
name varchar(50),
age int,
qualification varchar(20),
mobileno bigint,
mail_id varchar(50),
location varchar(30),
gender char(1));

insert into studentdetails values
(2,'sai',22,'b.e',9952836777,'sai@gmail.com','chennai','m'),
(3,'kumar',20,'bsc',7890125648,'kumar@gmail.com','madurai','m'),
(4,'selvi',22,'b.tech',8904567342,'selvi@gmail.com','salem','f'),
(5,'nisha',25,'m.e',7834672310,'nisha@gmail.com','theni','f'),
(6,'saisaran',21,'b.a',7890345678,'saran@gmail.com','madurai','f'),
(7,'tom',23,'bca',8901234675,'tom@gmail.com','pune','m');*/

select gender,count(*) as total_count
from studentdetails
group by gender;