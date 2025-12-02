--Problem Link : https://leetcode.com/problems/game-play-analysis-i/description/?envType=problem-list-v2&envId=e97a9e5m

select player_id,event_date[first_login] from (
        select player_id,event_date ,dense_rank()over(partition by player_id order by event_Date) [Dense]
        from activity) temp_table
where Dense = 1