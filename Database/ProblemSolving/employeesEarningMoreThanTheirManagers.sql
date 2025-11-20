Link to problem : https://leetcode.com/problems/employees-earning-more-than-their-managers/?envType=problem-list-v2&envId=e97a9e5m

/* Write your T-SQL query statement below */
select E.name [Employee]
from Employee E inner join Employee M
    on E.managerId = M.id
where E.salary > M.salary