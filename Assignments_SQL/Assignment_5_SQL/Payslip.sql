/*create table employee
(
    empid int,
    empname varchar(50),
    salary decimal(10,2)
);*/

--insert into employee values (1, 'ravi', 25000);
--insert into employee values (2, 'suresh', 30000);


create procedure employeepayslip
    @empid int
as
begin
declare
        @empname varchar(50),
        @salary decimal(10,2),
        @hra decimal(10,2),
        @da decimal(10,2),
        @pf decimal(10,2),
        @it decimal(10,2),
        @deductions decimal(10,2),
        @grosssalary decimal(10,2),
        @netsalary decimal(10,2);

select
@empname = empname,
@salary = salary from employee where empid = @empid;

set @hra = @salary * 10 / 100;
set @da  = @salary * 20 / 100;

set @pf = @salary * 8 / 100;
set @it = @salary * 5 / 100;

set @deductions = @pf + @it;
set @grosssalary = @salary + @hra + @da;
set @netsalary = @grosssalary - @deductions;

print 'employee payslip';
print 'employee id   : ' + cast(@empid as varchar);
print 'employee name : ' + isnull(@empname, 'not found');
print 'basic salary  : ' + cast(isnull(@salary,0) as varchar);
print 'hra (10%)     : ' + cast(isnull(@hra,0) as varchar);
print 'da (20%)      : ' + cast(isnull(@da,0) as varchar);
print 'gross salary  : ' + cast(isnull(@grosssalary,0) as varchar);
print 'pf (8%)       : ' + cast(isnull(@pf,0) as varchar);
print 'it (5%)       : ' + cast(isnull(@it,0) as varchar);
print 'total deduct. : ' + cast(isnull(@deductions,0) as varchar);
print 'net salary    : ' + cast(isnull(@netsalary,0) as varchar);
end;

exec employeepayslip 1;