declare @ProductCount int = 
    (select count(*) from Product);

select customer_id from Customer
group by customer_id
having count(distinct product_key) = @ProductCount;