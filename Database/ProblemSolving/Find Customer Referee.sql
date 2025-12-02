--Problem Link : https://leetcode.com/problems/find-customer-referee/?envType=problem-list-v2&envId=e97a9e5m

select name
from customer
where referee_id != 2 or referee_id is null