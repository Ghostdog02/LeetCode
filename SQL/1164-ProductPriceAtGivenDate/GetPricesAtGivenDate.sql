select product_id, price
from (
    select 
        product_id, 
        case 
            when change_date > '2019-08-16' then 10
            else new_price
        end as price,
        row_number() over (
            partition by product_id
            order by 
                case 
                    when change_date <= '2019-08-16' then 0
                    else 1
                end,
                abs(datediff(day, change_date, '2019-08-16'))
        ) as rn
    from Products
) as ranked
where rn = 1