select
    today.id
from
    Weather today
cross join
    Weather yesterday
where
    today.recordDate - yesterday.recordDate = 1
    and today.temperature > yesterday.temperature;