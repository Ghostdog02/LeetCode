select 
    p.project_id,
    round(avg(experience_years * 1.00), 2) as average_years
from Project p
join Employee e on e.employee_id = p.employee_id
group by p.project_id