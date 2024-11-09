select
    r.contest_id,
    ROUND(
        (COUNT(DISTINCT r.user_id) * 1.0 / 
        (SELECT COUNT(user_id) FROM Users)) * 100,
        2
    ) AS percentage
from
    Users u
join
    Register r
on
    u.user_id = r.user_id
group by
    r.contest_id
order by
    percentage desc,
    r.contest_id asc;