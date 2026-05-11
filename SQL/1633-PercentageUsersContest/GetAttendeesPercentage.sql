declare @totalUsers int
set @totalUsers = (
    select count(distinct user_id) from Users
)

select 
    contest_id,
    round(count(distinct user_id) * 100.00 / @totalUsers, 2) as [percentage]
from Register
group by contest_id
order by 
    round(count(distinct user_id) * 100.00 / @totalUsers, 2) desc, 
    contest_id asc