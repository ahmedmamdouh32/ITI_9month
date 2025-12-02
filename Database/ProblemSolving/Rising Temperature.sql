--Problem Link : https://leetcode.com/problems/rising-temperature/?envType=problem-list-v2&envId=e97a9e5m

select id from(
select id,temperature, recordDate,lag(temperature)over(order by recordDate)[prevTemp],lag(recordDate)over(order by recordDate)[prevdate]
from weather) table1
where temperature > prevTemp and datediff(day,prevdate,recordDate) = 1