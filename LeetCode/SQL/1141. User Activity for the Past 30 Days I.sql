select
    activity_date as day,
    count(distinct user_id) as active_users
from
    Activity
group by
    activity_date
having
    min(activity_date) >= date '2019-07-27' - 29
    and max(activity_date) <= '2019-07-27';