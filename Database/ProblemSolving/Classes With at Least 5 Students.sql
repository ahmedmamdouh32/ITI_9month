--Problem Link : https://leetcode.com/problems/classes-with-at-least-5-students/?envType=problem-list-v2&envId=e97a9e5m

select class
from courses
group by class
having count(*) >= 5