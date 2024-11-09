select
    query_name,
    ROUND(
        SUM(rating * 1.0 / position) / COUNT(rating),
        2
    ) as quality,
    ROUND(
        SUM(CASE WHEN rating < 3 THEN 1 ELSE 0 END) * 100.0 / COUNT(rating),
        2
    ) as poor_query_percentage
from
    Queries
group by
    query_name
having
    query_name is not null;