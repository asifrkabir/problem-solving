select
    employee_id,
    coalesce(
        max(case when primary_flag = 'Y' then department_id end),
        max(department_id)
    ) as department_id
from
    Employee
group by
    employee_id;