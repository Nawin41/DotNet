/*
4.Create table Employee with empno, ename, sal, doj columns or use your emp table and perform the following operations in a single transaction
  a. First insert 3 rows 
  b. Update the second row sal with 15% increment  
  c. Delete first row.
After completing above all actions, recall the deleted row without losing increment of second row.
*/

/*
use SQL_challenge_2;

create table employee(
empno int,
ename varchar(22),
sal int,
doj date);
*/

begin transaction;
--insert 3 rows
insert into employee values (1, 'Ram', 1000, '2026-01-01');
insert into employee values (2, 'Sam', 2000, '2026-02-01');
insert into employee values (3, 'Suresh', 3000, '2026-03-01');


save transaction after_insert;

--update second row(15% increment)
update employee
set sal = sal + (sal * 0.15)
where empno = 2;

save transaction after_update;

--delete first row
delete from employee
where empno = 1;


rollback transaction after_update;
commit;

select * from employee;