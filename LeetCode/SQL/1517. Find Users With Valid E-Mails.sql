select
    *
from
    Users
where
    mail ~ '^[a-zA-Z][a-zA-Z0-9_.-]*@leetcode\.com$';