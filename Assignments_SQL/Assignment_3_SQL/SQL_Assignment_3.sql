
--use SQL_assignment_2;
--1.Retrieve a list of managers
select ename
from emp
where job = 'manager';

--2.Names and salaries of employees earning more than 1000 per month
select ename, sal
from emp
where sal > 1000;

--3. Names and salaries of all employees except james
select ename, sal from emp
where ename <> 'james';


--4.Details of employees whose names begin with 's'
select * from emp
where ename like 's%';

--5. Names of employees having 'a' anywhere in their name
select ename from emp
where ename like '%a%';


--6.Names of employees having 'l' as their third character
select ename from emp
where ename like '__l%';


--7. Daily salary of jones (assuming 30 days/month)
select ename, sal / 30.0 as daily_salary from emp
where ename = 'jones';


--8.Total monthly salary of all employees
select sum(sal) as total_monthly_salary from emp;

--9.Average annual salary
select avg(sal * 12) as avg_annual_salary from emp;

--10.Employees except salesman from department 30
select ename, job, sal, deptno from emp
where not (job = 'salesman' and deptno = 30);

--11.Unique departments in emp table
select distinct deptno from emp;

--12.Employees earning more than 1500 in department 10 or 30 
select ename as employee, sal as monthly_salary from emp
where sal > 1500 and deptno in (10, 30);


--13.Manager or analyst whose salary is not 1000, 3000, or 5000
select ename, job, sal from emp
where job in ('manager', 'analyst') and sal not in (1000, 3000, 5000);


--14.Employees whose commission is greater than salary increased by 10%
select ename, sal, comm from emp
where comm > sal * 1.10;


--15.Employees with two 'l's in name and (dept 30 or manager 7782)
select ename from emp
where ename like '%l%l%' and (deptno = 30 or mgr_id = 7782);


--16.Count employees with experience between 30 and 40 years
select count(*) as total_employees from emp
where datediff(year, hiredate, getdate()) between 30 and 40;


--17.Departments in ascending order and employees in descending order
select d.dname, e.ename from dept d
join emp e on d.deptno = e.deptno
order by d.dname asc, e.ename desc;


--18.Experience of miller (in years)
select ename,datediff(year, hiredate, getdate()) as experience_years from emp
where ename = 'miller';