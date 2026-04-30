use SQL_challenge_1;

--3.Display the  reviewer name who reviewed more than one book. 

select reviewer_name from reviews
group by reviewer_name
having count(distinct book_id) > 1;
