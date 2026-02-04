

  select e.dept,e.name,e.salary from [dbo].[EmpoyeeTb] e join (
  select dept,Max(salary)as maxsalary from [dbo].[EmpoyeeTb]  group by dept
  ) m on e.dept=m.dept where e.salary=m.maxsalary