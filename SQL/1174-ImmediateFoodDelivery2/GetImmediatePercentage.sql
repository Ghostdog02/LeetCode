with FistOrders as (
    select customer_id, min(order_date) as order_date
    from Delivery
    group by customer_id
)

select 
    round(avg
    (
        case 
            when d1.order_date = d1.customer_pref_delivery_date
                then 1.00
            else 0.00
        end 
    ) * 100, 2) as immediate_percentage
from Delivery d1
join FistOrders fo on d1.customer_id = fo.customer_id
    and fo.order_date = d1.order_date