Problem Link : https://leetcode.com/problems/big-countries/submissions/1845450881/?envType=problem-list-v2&envId=e97a9e5m

select name, population, area
from World
where area>=3000000 or population>=25000000