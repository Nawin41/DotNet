use SQL_assignment_2;

/*
3.  Write a query to display all employees information those who joined before 5 years in the current month

 

(Hint : If required update some HireDates in your EMP table of the assignment)

*/

update emp
set hiredate = '2022-05-10'
where empno = 7876;

update emp
set hiredate = '2023-05-20'
where empno = 7499;

update emp
set hiredate = '2023-05-15'
where empno = 7782;

update emp
set hiredate = '2019-05-12'
where empno = 7876;

update emp
set hiredate = '2016-05-08'
where empno = 7782;

update emp
set hiredate = '2015-05-25'
where empno = 7788;

select * from emp where hiredate < dateadd(year, -5, getdate()) 
and month(hiredate) = month(getdate());


