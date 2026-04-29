/*create table emp
(
    empid int,
    empname varchar(50),
    salary int
);
create table holiday
(
    holiday_date date,
    holiday_name varchar(50)
);

insert into holiday values ('2024-01-26', 'republic day');
insert into holiday values ('2024-08-15', 'independence day');
insert into holiday values ('2024-10-31', 'diwali');
insert into holiday values ('2024-12-25', 'christmas');  */

create trigger trg_restrict_emp_holiday1 on emp
after insert, update, delete
as
begin
    declare @holidayname varchar(50);

--check if today is a holiday
select @holidayname = holiday_name from holiday where holiday_date = cast(getdate() as date);

--if today is holiday, stop operation
if @holidayname is not null
begin
rollback transaction;
raiserror('due to %s you cannot manipulate data',16,1,@holidayname);
    end
end;


--testiing
insert into emp values (1, 'ravi', 25000);