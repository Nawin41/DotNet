/*
5.      Create a user defined function calculate Bonus for all employees of a  given dept using   following conditions
  a.     For Deptno 10 employees 15% of sal as bonus.
  b.     For Deptno 20 employees  20% of sal as bonus
  c      For Others employees 5%of sal as bonus
*/
use SQL_challenge_2;
/*
create table emp(
empno int,
ename varchar(20),
sal int,
deptno int);
insert into emp values (101, 'John', 1000, 10);
insert into emp values (102, 'Dev', 2000, 20);
insert into emp values (103, 'Ramesh', 1500, 30);
insert into emp values (104, 'Senthil', 3000, 10);
insert into emp values (105,'Ram',750,30);
*/

create function dbo.bonus
(
@deptno int,
@sal int
)
returns int
as
begin
    declare @bonus int;

    if @deptno = 10
        set @bonus = @sal * 0.15;
    else if @deptno = 20
        set @bonus = @sal * 0.20;
    else
        set @bonus = @sal * 0.05;

    return @bonus;
end;

select empno, ename, deptno, sal,dbo.bonus(deptno, sal) as bonus
from emp;
