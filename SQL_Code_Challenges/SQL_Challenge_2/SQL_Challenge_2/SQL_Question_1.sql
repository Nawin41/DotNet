--use SQL_challenge_2;

--1. Write a query to display your birthday( day of week)


select datename(weekday, '2004-04-05') as day_of_birthday;
