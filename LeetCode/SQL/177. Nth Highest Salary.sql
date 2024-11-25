CREATE OR REPLACE FUNCTION NthHighestSalary(N INT) RETURNS TABLE (Salary INT) AS $$
BEGIN
  RETURN QUERY (
    -- Write your PostgreSQL query statement below.
    select
        distinct e.salary
    from
        Employee e
    where
        N > 0
    order by
        e.salary desc
    offset
        case when N > 0 then (N-1) else 0 end
    limit
        case when N > 0 then 1 else 0 end
  );
END;
$$ LANGUAGE plpgsql;