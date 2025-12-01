use ITI

declare @x int=(select avg(st_age) from student)

set @x=10

select @x=9

select @x

declare @x int
	select @x=st_age from Student
	where st_id=5
select @x


declare @x int
	select @x=st_age from Student
	where st_id=-1
select @x


declare @x int
	select @x=st_age from Student
	where St_Address='alex'
select @x

--Arrays --variable table
declare @t table(col1 int) ---> 1D array of integers
	insert into @t
	values(4),(6),(9)
select * from @t
select count(*) from @t

declare @t table(col1 int) ---> 1D array of integers
	insert into @t
	select st_age from Student where st_address='cairo'
select * from @t
select count(*) from @t

declare @t table(col1 int,col2 varchar(20)) ---> 2D array
	insert into @t
	select st_age,st_Fname from Student where st_address='cairo'
select * from @t
select count(*) from @t

declare @s int
	update Instructor
		set ins_name='ahmed' , @s=salary
	where ins_id=3
select @s

--Variables   --dynamic queries

declare @par int=7

select * from Student
where st_id=@par

declare @par int=4

select top(@par)*
from Student

--metadata    --dynamic
declare @col varchar(20)='salary',@t varchar(20)='instructor'
execute('select '+@col+' from '+@t)

declare @col varchar(20)='*',@t varchar(20)='instructor',@cond varchar(20)='salary>1000'
execute('select '+@col+' from '+@t+' where '+@cond)

select 'select * from student'
execute( 'select * from student')

declare @y int,@name varchar(20)
	select @y=st_age , @name=st_fname from Student
	where st_id=1
select @y,@name

--Global var
select @@SERVERNAME

select @@version

update Instructor set Salary+=100
select @@ROWCOUNT

select * from Instructor where salary>1000
select @@ROWCOUNT
select @@ROWCOUNT

select * from Instructor where salary>1000
go
select @@ERROR




create table test (id int primary key identity,ename varchar(20))

insert into test values('ahmed')
select @@IDENTITY

--------------------------------------------------------------
--control of flow statment
--if
declare @x int
	update Student set st_age+=1
set @x=@@ROWCOUNT
if @x>0 
	begin
		select 'multi rows affected'
		select 'welcome to iti'
	end
else 
	begin
		select 'zero rows affected'
	end
--begin end
--if exists if not exists

if exists(select name from sys.tables where name='exam')
	select 'table is existed'
else
	create table exam
	(
	id int,
	ename varchar(20)
	)

if not exists(select top_id from course where top_id=10)
	delete from topic where top_id=10
else
	select 'table has relation'

begin try
	delete from topic where top_id=2
end try
begin catch
	select 'error'
	select ERROR_LINE(),ERROR_MESSAGE(),ERROR_NUMBER()
end catch

--while
declare @x int=10
while @x<=20
	begin
		set @x+=1
		if @x=14
			continue
		if @x=16
			break
		select @x
	end

--continue break
--iif case
select ins_name ,salary,
                case
					when salary>=5000 then 'high salary'
					when Salary<5000 then 'low'
					else 'No data'
				end as Col2
from Instructor

select ins_name ,iif(salary>=5000,'high','low')
from Instructor

update Instructor
	set Salary=Salary*1.20

update Instructor
	set Salary=
				case
					when salary>=5000 then salary*1.10
					else salary*1.20
				end
--choose
--waitfor
--------------------------------------------------------
--functions
--user defined functions
---scalar
--functions      fun_name    Paramters   return_value   body
alter function getsname(@id int)
returns varchar(30)
	begin
		declare @name varchar(30)
			select @name=st_fname from Student
			where st_id=@id
		return @name  
	end

--calling
select dbo.getsname(1)
alter schema hr transfer getsname
select hr.getsname(3)
alter schema dbo transfer hr.getsname
drop function getsname

--inline
create function getinsts(@did int)
returns table
as
	return
		(
		 select ins_name,salary*12 as annualsal
		 from Instructor
		 where Dept_Id=@did
		)

--calling
select * from getinsts(10)
select ins_name from getinsts(10)
select sum(annualsal) from getinsts(10)

--multi
create function getstuds(@format varchar(20))
returns @t table
            (
			  id int,
			  sname varchar(30)
			)
as
	begin
		if @format='first'
			insert into @t
			select st_id,st_fname from Student
		else if @format='last'
			insert into @t
			select st_id,st_lname from Student
		else if @format='fullname'
			insert into @t
			select st_id,concat(st_fname,' ',st_lname) from Student
		return
	end

--calling
select * from getstuds('first')
---------------------------------------
--execute + dynamic + function  XXXXX
create function fun1()
returns
	begin
	   execute('')
	end
------------------------------------------
--built-in functions
--NULL
select isnull(st_fname,'')
from Student

select coalesce(st_fname,st_lname,st_address,'')
from Student

--data conversion
select convert(varchar(20),getdate())
select cast(getdate() as varchar(20))

select convert(varchar(20),getdate(),101)
select convert(varchar(20),getdate(),102)
select convert(varchar(20),getdate(),103)
select convert(varchar(20),getdate(),104)
select convert(varchar(20),getdate(),105)

select format(getdate(),'dd-MM-yyyy')
select format(getdate(),'dddd MMMM yyyy')
select format(getdate(),'ddd MMM yy')
select format(getdate(),'dddd')
select format(getdate(),'MMMM')
select format(getdate(),'hh:mm:ss')
select format(getdate(),'hh')
select format(getdate(),'hh tt')
select format(getdate(),'dd-MM-yyyy hh:mm:ss tt')

select FORMAT(getdate(),'yyyy')  --return string
select YEAR(getdate()) --return int

select eomonth(getdate())
select format(eomonth(getdate()),'dd')
select format(eomonth(getdate()),'dddd')

select eomonth(getdate(),+2)
select eomonth(getdate(),-1)

--system functions
select db_name()

select SUSER_NAME()

insert into test values('ali')
select SCOPE_IDENTITY()

select IDENT_CURRENT('test')

select OBJECT_ID('student')
select OBJECT_ID('staff')

if OBJECT_ID('exam') is not null
	select 'table is existed'

--Aggregate functions
select count(*),count(st_age)
from Student

--math function
sin cos tan log power abs sqrt

select abs(-5)
select SQRT(25)

--date function
getdate() day month year
select datediff(year,'1/1/2000','1/1/2010')
select datediff(month,'1/1/2000','1/1/2010')
select datediff(day,'1/1/2000','1/1/2010')

--logical functions
iif

select isdate('1/1')
select isdate('1/1/2000')

select ISNUMERIC('4343t')
select ISNUMERIC('4343')

--string
select concat('ahmed',434,'cairo',null,4666.32)
select concat_ws('  &  ','ahmed',434,'cairo',null,4666.32)
select concat_ws('  -  ','ahmed',434,'cairo',null,4666.32)

select UPPER(st_fname),lower(st_lname)
from Student

select len(st_fname) , st_fname
from Student

select SUBSTRING(st_fname,1,3)
from Student

select SUBSTRING(st_fname,3,3)
from Student

select SUBSTRING(st_fname,1,len(st_fname)-1)
from Student

select REVERSE('ahmed')

select REPLICATE('ahmed',3)

select REPLICATE(st_fname,3)
from Student

select st_fname+space(10)+st_lname
from Student

select CHARINDEX('a','mohamed')
select CHARINDEX('a',ins_name)
from Instructor

select REPLACE('ahmed$gmail.com','$','@')

select stuff('ahmedomarkhalid',6,4,'ali')

select trim('    ahmed   ')
select ltrim('    ahmed   ')
select Rtrim('    ahmed   ')

select top(1)st_fname
from student
order by len(st_fname) desc

--variables   local  global
--control of flow statements
--windowing function
--functions    builtin    user defined


