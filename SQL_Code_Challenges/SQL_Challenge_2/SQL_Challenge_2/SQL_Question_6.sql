/*
6. Create a procedure to update the salary of employee by 500 whose dept name is Sales and current salary is below 1500 (use emp table)
*/
use SQL_challenge_2;

/*
create table dept(
deptno int,
dname varchar(20));

insert into dept values (10, 'Accounting');
insert into dept values (20, 'Research');
insert into dept values (30, 'Sales');

*/

create procedure salary_sales
as
begin
    update e
    set e.sal = e.sal + 500
    from emp e
    join dept d on e.deptno = d.deptno
    where d.dname = 'Sales'
      and e.sal < 1500;
end;

exec salary_sales;

select * from emp;