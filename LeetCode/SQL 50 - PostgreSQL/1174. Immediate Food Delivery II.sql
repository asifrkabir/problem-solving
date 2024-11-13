select
    round(
        (sum(case
                when order_date = customer_pref_delivery_date then 1
                else 0
            end) * 100.0) / count(*),
        2
    ) as immediate_percentage
from (
    select
        customer_id,
        order_date,
        customer_pref_delivery_date
    from
        Delivery
    where
        (customer_id, order_date)
    in (
        select
            customer_id,
            min(order_date)
        from
            Delivery
        group by
            customer_id
    )
);