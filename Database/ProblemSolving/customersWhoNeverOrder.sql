Problem Link : https://leetcode.com/problems/customers-who-never-order/description/?envType=problem-list-v2&envId=e97a9e5m
select name [Customers]
from customers 
where id not in (select customerId from orders)