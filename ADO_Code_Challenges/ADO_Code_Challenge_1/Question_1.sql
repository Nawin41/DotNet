/*
create database Employeemanagement;
use Employeemanagement;
create table Employee_Details (
Empno int primary key,
EmpName varchar(100) not null,
Empsal numeric(10,2) check (Empsal >= 25000),
Emptype char(1) check (Emptype IN ('F','P')));
*/
create procedure Employee
    @EmpName varchar(100),
    @Empsal numeric(10,2),
    @Emptype char(1)
as
begin
declare @Empno int;
select @Empno = ISNULL(MAX(Empno), 0) + 1 from Employee_Details;

--Insert
insert into Employee_Details (Empno, EmpName, Empsal, Emptype)
values (@Empno, @EmpName, @Empsal, @Emptype);
end;

exec Employee 'Ramesh', 30000, 'F';
exec Employee 'Suresh', 28000, 'P';

select * from Employee_Details;
