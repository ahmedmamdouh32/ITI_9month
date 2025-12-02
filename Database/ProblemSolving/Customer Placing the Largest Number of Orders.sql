Problem Link : https://leetcode.com/problems/customer-placing-the-largest-number-of-orders/?envType=problem-list-v2&envId=e97a9e5m

select top(1)customer_number 
from Orders
group by customer_number
order by count(*) desc