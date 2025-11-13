--fullPath
--ServerName.DBName.SchemaName.Objectname

select * from Student

select * from [Rami].ITI.dbo.student

select * from Project  --[Rami].[ITI].dbo.Project  XXXXX

select * from Company_SD.dbo.Project

select dept_name from department
union all
select dname from Company_SD.dbo.Departments

--->SQL server Setup configurations
--instance [services+app]
--types of instaces [default,named instance]
--Security [authentication] [authorization]
--fullpath
--Transact_SQL
--top   selectinto   newid  insertbasedonselect  bulkinsert Ranking  merge
select *
from Student

select *
from Student
where St_Address='alex'

select top(3)*
from Student

select top(1)*
from Student

select top(1)*
from Student
where st_address='alex'

select top(5) st_fname 
from Student

select Max(Salary)
from Instructor

select top(2) Max(Salary)
from Instructor

--from  select   order   top
select top(2) salary
from Instructor
order by Salary desc

--newid()  --GUID
select newid()

select * , newid() as Xid
from Student
order by Xid

select top(1)*
from Student

select top(1)*
from Student
order by newid()

select top(10)*
from questions
order by newid()

--select into
--ddl
--create table from existing
select *
from Student

select * into tab2
from Student

select * into tab3
from Student

select st_id,st_fname into tab5
from Student
where St_Address='alex'

select * into student
from Student

select * into company_Sd.dbo.student
from Student

select * into tab7
from student
where 1=2  --false condition   age<0

-----insert based on select
insert into tab5
values(33,'ahmed')

insert into tab5
values(338,'ali'),(554,'reem'),(999,'reem')

insert into tab5
select ins_id,ins_name from Instructor where Salary>5000

--bulk insert
--insert data from file
bulk insert tab5
from 'E:\Mydata.txt'
with(fieldterminator=',')

--Ranking
select *
from (select * , Row_number() over(order by st_age desc) as RN
      from Student) as X
where RN=1

select *
from (select * , Dense_Rank() over(order by st_age desc) as DR
      from Student) as X
where DR=1

select *
from (select * , NTile(3) over(order by st_age desc) as G
      from Student) as X
where G=1

select *
from (select * , Row_number() over(Partition by dept_id order by st_age desc) as RN
      from Student) as X
where RN=1

select *
from (select * , Dense_Rank() over(Partition by dept_id order by st_age desc) as DR
      from Student) as X
where DR=1

select *
from (select * , NTile(2) over(Partition by dept_id order by st_id desc) as G
      from Student) as X

select *
from (select * , NTile(2) over(Partition by dept_id order by st_id desc) as G
      from Student) as X
where G=1 and Dept_Id=10

select *
from (select * , NTile(2) over(Partition by dept_id order by st_id desc) as G
      from Student) as X
where G=1 













