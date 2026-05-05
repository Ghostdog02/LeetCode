select 
    sell_date,
    count(product) as num_sold,
    string_agg(product, ',') within group (order by product) as products
from (
    select distinct sell_date, product from Activities
) as distinct_products
group by sell_date
order by sell_date