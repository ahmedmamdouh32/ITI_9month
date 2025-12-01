Problem link : https://leetcode.com/problems/delete-duplicate-emails/?envType=problem-list-v2&envId=e97a9e5m

delete from person 
where id not in 
	(select id 
		from (select id ,email,DENSE_RANK()over(partition by email order by id) Rank
			  from person) temp_table
		where Rank  = 1)