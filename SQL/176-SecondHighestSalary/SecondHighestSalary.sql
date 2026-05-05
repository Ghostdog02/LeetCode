select (
    select top 1 e1.salary from Employee e1
    where e1.salary < (
        select max(salary) from Employee
    )
    order by e1.salary desc
) as SecondHighestSalary