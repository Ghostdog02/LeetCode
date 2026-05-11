select round(1.00 * count(Players.player_id) / (
        select count(distinct player_id) from Activity
    ), 2) as fraction 
from (
    select a1.player_id
    from Activity a1
    where event_date in (
        select dateadd(day, 1, min(event_date)) from Activity
        where a1.player_id = player_id
    )
    group by a1.player_id
) as Players