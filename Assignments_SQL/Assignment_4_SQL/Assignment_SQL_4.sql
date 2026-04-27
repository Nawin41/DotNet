--1.Write a T-SQL Program to find the factorial of a given number.
declare @n int = 5;
declare @fact bigint = 1;
declare @i int = 1;

while @i <= @n
begin
    set @fact = @fact * @i;
    set @i = @i + 1;
end

print 'factorial is ' + cast(@fact as varchar);

--2.Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 

create procedure multiplication_table
    @num int,
    @limit int
as
begin
    set nocount on;

    declare @i int;

    set @i = 1;

    while @i <= @limit
    begin
        print cast(@num as varchar) + ' * ' +
              cast(@i as varchar) + ' = ' +
              cast(@num * @i as varchar);
        set @i = @i + 1;
    end
end;

exec multiplication_table 5,10;

--3.Create a function to calculate the status of the student. If student score >=50 then pass, else fail. Display the data neatly
create function student_status (@score int)
returns varchar(10)
as
begin
    declare @status varchar(10);

    if @score >= 50
        set @status = 'pass';
    else
        set @status = 'fail';
    return @status;
end;

select s.sid,s.sname,m.score,dbo.student_status(m.score) as status from student s
join marks m on s.sid = m.sid
order by s.sid;

