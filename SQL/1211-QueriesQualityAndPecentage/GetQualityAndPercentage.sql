select 
    query_name,
    round((sum(rating * 1.00 / position) * 1.00 / count(*)), 2) as quality,
    round(
        (sum(case when rating < 3 then 1 else 0 end) * 100.00 / count(*)), 2
    ) as poor_query_percentage
from Queries
group by query_name