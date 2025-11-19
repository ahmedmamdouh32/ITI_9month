--problem link : https://leetcode.com/problems/combine-two-tables/description/?envType=problem-list-v2&envId=e97a9e5m

/* Write your T-SQL query statement below */
select P.firstName, P.lastName, A.city, A.state
from Person P left outer  join Address A
    on P.personId = A.personId