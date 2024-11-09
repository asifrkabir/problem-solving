select
    man.name
from
    Employee man
join
    Employee emp
on
    man.id = emp.managerId
group by
    man.id, man.name
having
    count(emp.id) >= 5;