select 
    p.product_id, 
    case 
        when count(us.units) = 0 then 0 
        else round(sum(p.price * us.units) * 1.00 / sum (us.units), 2) 
    end as average_price
from Prices p
left join UnitsSold us on us.product_id = p.product_id 
    and us.purchase_date >= p.start_date 
    and us.purchase_date <= p.end_date
group by p.product_id