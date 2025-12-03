Problem Link : https://leetcode.com/problems/sales-person/?envType=problem-list-v2&envId=e97a9e5m

select name
from salesperson
where sales_id not in (select S.sales_id
                        from SalesPerson S inner join orders O
                            on S.sales_id = O.sales_id
                            inner join Company C
                            on C.com_id = O.com_id
                            where C.name = 'red'
                       )