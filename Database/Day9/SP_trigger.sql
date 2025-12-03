use ITI


create  Proc getgrades
as
	SELECT Course.Crs_Name, Stud_Course.Grade, Student.St_Fname, Student.St_Id
	FROM   Course INNER JOIN
             Stud_Course ON Course.Crs_Id = Stud_Course.Crs_Id INNER JOIN
             Student ON Stud_Course.St_Id = Student.St_Id
	WHERE (Stud_Course.Grade > 50)
	ORDER BY Course.Crs_Name

--calling
getgrades
execute getgrades
exec getgrades

create Proc getstbyadd @add varchar(20)
with encryption
as
	select st_id,st_fname
	from Student
	where St_Address=@add

--calling

getstbyadd 'cairo'
getstbyadd 'alex'
alter schema hr transfer getstbyadd
hr.getstbyadd 'alex'
alter schema dbo transfer hr.getstbyadd
sp_helptext 'getstbyadd'
drop proc getstbyadd

--DML
alter Proc Deltopic @tid int
as
	if not exists(select top_id from course where top_id=@tid)
		delete from topic where top_id=@tid
	else
		select 'table has relationship'


Deltopic 50
---------------------------------------------
alter Proc getdata @x int=200,@y int=100
as
	select @x+@y

getdata 5,8  --passing Parameters by position
getdata @y=7,@x=3 --passing parameters by name
getdata 4
getdata

----------------------------------
--return values
create Proc getstbyadd @add varchar(20)
as
	select st_id,st_fname
	from Student
	where St_Address=@add

--1
getstbyadd 'alex'

--2
declare @t table(x int,y varchar(20))
	insert into @t
	execute getstbyadd 'alex'
select * from @t
select count(*) from @t

--3
insert into grades(sid,sname)
execute getstbyadd 'alex'

--SP   return one value  --->scalar function
create Proc getmydata @id int
as
	declare @age int
		select @age=st_age from Student
		where st_id=@id
	return @age

--calling
declare @x int
	execute @x=getmydata 5
select @x

alter Proc getmydata @id int ,@age int output
as
		select @age=st_age from Student
		where st_id=@id
	
--calling
declare @x int
	execute getmydata 5 ,@x output
select @x

alter Proc getmydata @id int ,@age int output,@name varchar(20) output
as
		select @age=st_age,@name=st_fname from Student
		where st_id=@id
	
--calling
declare @x int,@y varchar(20)
	execute getmydata 1 ,@x output,@y output
select @x,@y
--------------------------------------------------------------------------------
alter Proc getmydata @z int output,@name varchar(20) output
as
		select @z=st_age,@name=st_fname from Student
		where st_id=@z
	
--calling
declare @x int=1,@y varchar(20)
	execute getmydata @x output,@y output
select @x,@y





--dynamic query  --execute
create Proc getvalues @col varchar(20),@t varchar(20)
as
	execute('select '+@col+' from '+@t)


--calling
getvalues 'salary','instructor'
---------------------------------------------------------------------
--3 types of SP
--------------
--builtin SP
SP_bindrule  sp_helptext  sp_helpconstraint  sp_rename

--user defined SP
getstuds  getstbyadd deltopic  sumdata

--Triggers
--special type of SP
--can't call
--can't take parameter
--implicit code
--automatic firing according actions
--triggers table [insert  update  delete]  log            [select & truncate]XXXXX  
--Server     --db   --schema   --object


create trigger tr_1
on student
after insert
as
	select 'welcome to ITI'

insert into student(St_id,st_fname)
values(440,'ahmed')

create trigger tr_2
on student
for update
as
	select suser_name(),db_name(),host_name(),getdate()

update Student set st_age+=1

create trigger tr_3
on student
instead of delete
as
	select 'not allowed'

delete from Student where st_id=44

create trigger tr_4
on department
instead of insert,update,delete
as
	select 'not allowed for user= '+suser_name()

update Department set Dept_Name='cloud'
where Dept_Id=10

alter table department disable trigger tr_4

alter table department enable trigger tr_4

---
alter trigger tr_5  
on course
after update
as
	if update(crs_name)
		select 'course is updated'
	else
		select GETDATE()

update Course
	set Crs_name='html'
where Crs_Id=200

alter schema dbo transfer hr.course

create trigger tr_6
on course
after update
as
	select * from deleted
	select * from inserted

update course
	set crs_name='js',Crs_Duration=55,top_id=4
where crs_id=100


update course
	set crs_name='cloud',Crs_Duration=66,top_id=1
where crs_id=200

create trigger t9
on course
instead of delete
as
	select 'not allowed to delete course name = '+(select crs_name from deleted)

delete from Course where crs_id=1000
delete from Course where crs_id=1200

create trigger t10
on student
instead of delete
as
	if (format(getdate(),'dddd'))='friday'
		select 'not allowed'
	else
		delete from student where st_id in (select st_id from deleted)


create trigger t10
on student
after delete
as
	if (format(getdate(),'dddd'))='friday'
		begin
			select 'not allowed'
		insert into student
		select * from deleted
		end
------------------------------------
create table history_audit
(
 _user varchar(100),
 _date date,
 _olddata int,
 _newdata int,
 _action_Notes varchar(100)
)

create trigger tr_test
on topic
instead of update
as
	if update(top_id)
		begin
			declare @old int,@new int
				select @old=top_id from deleted
				select @new=top_id from inserted
			insert into history_audit
			values(suser_name(),getdate(),@old,@new,'update table topic')
		end


create trigger tr_test2
on department
instead of delete
as
	insert into history_audit
	values(suser_name(),getdate(),(select dept_id from deleted),NULL,'delete department')

-------------------------------------------------
--output  --runtime trigger

update Instructor
	set Salary=9000
output suser_name(),getdate(),inserted.Salary,deleted.Salary,'update instructor' into [dbo].[history_audit]
where Ins_Id=88


delete from Instructor
output 'one row deleted'
where Ins_Id=66
-------------------------------------------------
--Batch    script   transaction

--batch
--set of indenpendent queries

insert
update
delete

--ddl
--script
--set of batch separated by go

create table
go
create view
go
alter function

--transaction
--set of dependent queries
--run as single unit work

create table parent (pid int primary key)

create table child( cid int foreign key references parent(Pid))

insert into parent values(1)
insert into parent values(2)
insert into parent values(3)
insert into parent values(4)


begin transaction
	insert into child values(1)
	insert into child values(2)
	insert into child values(3)
rollback

begin transaction
	insert into child values(1)
	insert into child values(2)
	insert into child values(3)
commit

begin try
	begin transaction
		insert into child values(1)
		insert into child values(2)
		insert into child values(3)
	commit
end try
begin catch
	rollback
	select ERROR_LINE(),ERROR_MESSAGE(),ERROR_NUMBER()
end catch


	begin transaction
		insert into child values(1)
		insert into child values(2)  
		insert into child values(300)
	commit




select * from child
truncate table child























delete from Instructor
where Ins_Id=77















































