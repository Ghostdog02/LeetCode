select results from (
    select top 1 u.name as results
    from Users u
    join MovieRating mr on u.user_id = mr.user_id
    group by u.user_id, u.name
    order by count(movie_id) desc, u.name asc
) as query1   

union all

select results from (    
    select top 1 m.title as results
    from Movies m
    join MovieRating mr on m.movie_id = mr.movie_id
    where year(mr.created_at) = 2020 AND month(mr.created_at) = 2
    group by m.movie_id, m.title
    order by avg(cast(rating as decimal)) desc, m.title asc
) as query2