select 
    t1.id,
    case 
        when t1.p_id is null then 'Root'
        when (
            select count(t2.p_id) from Tree t2
            where t2.p_id = t1.id
        ) > 0 then 'Inner'
        else 'Leaf'
    end as [type]
from Tree t1