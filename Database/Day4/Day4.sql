select salary
from instructor

select Sum(salary) as Total
from instructor

select count(ins_id)
from Instructor

select min(salary),max(salary)
from Instructor

select count(*),count(st_id),count(st_fname),count(st_age)
from Student

select avg(st_age)
from Student

select avg(isnull(st_age,0))
from Student

select sum(St_age)/count(*)
from Student

select sum(salary),dept_id
from Instructor
group by Dept_Id

select sum(salary),d.dept_id,dept_name
from Instructor i inner join Department d
	on d.Dept_Id=i.Dept_Id
group by d.Dept_Id,dept_name

select count(st_id),st_address
from Student
group by St_Address

select count(st_id),dept_id
from Student
group by dept_id

select count(st_id),dept_id,st_address
from Student
group by dept_id,St_Address

select count(st_id),dept_id
from Student
group by dept_id


select sum(salary),dept_id
from Instructor
group by Dept_Id

select sum(salary),dept_id
from Instructor
where salary>1000
group by Dept_Id

select sum(salary),dept_id
from Instructor
group by Dept_Id

select sum(salary),dept_id
from Instructor
group by Dept_Id
having sum(Salary)>30000

select sum(salary),dept_id
from Instructor
group by Dept_Id
having count(ins_id)<6

--having without group by
select sum(salary),avg(salary)
from Instructor
having count(ins_id)<100
--------------------------------------------------
--subqueries
select *
from Student
where st_age<(select avg(st_age) from Student)

select *,(select count(st_id) from Student)
from Student

select dept_name
from Department
where Dept_Id in (select distinct Dept_Id
                  from Student
				  where Dept_Id is not null)

select distinct dept_name
from Student s inner join Department d
	on d.Dept_Id=s.Dept_Id


--Joins + DML
--Subqueries +DML
delete from Stud_Course
where st_id=3

delete from Stud_Course
where crs_id in(select crs_id from Course where crs_name in('DB','html'))


--set operators
--union all      union    intersect   except

--batch    ---set of independent queries

select st_fname
from Student
union all
select ins_name
from Instructor

select st_fname as ITInames
from Student
union all
select ins_name
from Instructor

select st_fname,st_id
from Student
union all
select ins_name,ins_id
from Instructor

select convert(varchar(20),st_id)
from Student
union all
select ins_name
from Instructor

select st_fname
from Student
union --distinct --order+unique
select ins_name
from Instructor

select st_fname
from Student
intersect
select ins_name
from Instructor

select st_fname,st_id
from Student
intersect
select ins_name,ins_id
from Instructor

select st_fname
from Student
except
select ins_name
from Instructor

-->Agg functions + grouping  +having
-->subueries
-->set operators
-->EERD
-->execution cycle
select st_fname , dept_id ,st_age
from Student
where st_address='alex'

select st_fname , dept_id ,st_age
from Student
order by st_address

select st_fname , dept_id ,st_age
from Student
order by 3

select st_fname , dept_id ,st_age
from Student
order by dept_id desc,st_age asc

select st_fname+' '+st_lname as fullname
from Student
order by fullname

select st_fname+' '+st_lname as fullname
from Student
where fullname='ahmed hassan'

select st_fname+' '+st_lname as fullname
from Student
where st_fname+' '+st_lname='ahmed hassan'

select *
from (select st_fname+' '+st_lname as fullname
      from Student) as newtable
where fullname='ahmed hassan'

--execution order
--from
--join
--on
--where
--group
--having
--select
--order
--top
--into

drop  table student   --DDL  Data&metadata     child     ===>recreate

delete from student  --DML   --data   --where  --slower  --log  --rollback
                     --parent & child

truncate table student --data --faster  --sometimes log  --can't rollback
                       --child   --ddl   --reset identity

insert into test  values('ahmed')

select * from test

delete from test

truncate table test















