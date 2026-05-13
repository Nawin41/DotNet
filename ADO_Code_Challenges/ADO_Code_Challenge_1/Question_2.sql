Use Employeemanagement;

create procedure UpdateSalary
@Empno int,
@UpdatedSalary numeric(10,2) output
as
begin
-- Update salary
update Employee_Details
set Empsal = Empsal + 100
where Empno = @Empno;

-- Return updated salary
select @UpdatedSalary = Empsal
from Employee_Details
where Empno = @Empno;
end;

declare @sal numeric(10,2);

exec UpdateSalary 1, @sal output;

select @sal as UpdatedSalary;
select * from employee_details;
