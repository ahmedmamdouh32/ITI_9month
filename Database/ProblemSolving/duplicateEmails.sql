Problem link : https://leetcode.com/problems/duplicate-emails/?envType=problem-list-v2&envId=e97a9e5m

select email
from Person
group by email
having count(*) > 1 