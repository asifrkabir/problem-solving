select
    u.name,
    coalesce(
        sum(distance),
        0
    ) as travelled_distance
from
    Users u
left join
    Rides r
on
    u.id = r.user_id
group by
    u.id,
    u.name
order by
    coalesce(
        sum(distance),
        0
    ) desc,
    name asc;