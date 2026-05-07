use SQL_challenge_2;

--2.Write a query to display your age in days


select datediff(day, '2004-04-05', getdate()) as Age_In_Days;