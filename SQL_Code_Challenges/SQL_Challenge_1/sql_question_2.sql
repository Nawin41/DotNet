use SQL_challenge_1;

--2.Display the Title ,Author and ReviewerName for all the books from the above table  

/*create table reviews(
id int primary key,
book_id int,
reviewer_name varchar(100),
content varchar(200),
rating int,
published_date datetime);

insert into reviews values
(1,1,'john smith','my first review',4,'2017-12-10 05:50:11'),
(2,2,'john smith','my second review',5,'2017-10-13 15:05:12'),
(3,2,'alice walker','another review',1,'2017-10-22 23:47:10'); */


select b.title,b.author,r.reviewer_name
from books b join reviews r on b.id = r.book_id;
