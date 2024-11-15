select
    user_id,
    initcap(substring(name, 1, 1)) || lower(substring(name, 2)) as name
from
    Users
order by
    user_id asc;