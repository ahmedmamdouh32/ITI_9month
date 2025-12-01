--1.	Create a scalar function that takes date and returns Month name of that date.
create function getMonthName (@date date)
returns varchar(10) 
as 
begin
return(select format(@date,'MMMM'))
end

--2.	 Create a multi-statements table-valued function that takes 2 integers 
--and returns the values between them.
create function returnInBetween(@var1 int, @var2 int)
returns @t table(
					n int
				)

	as
	begin
	declare @i int
	set @i = case when @var1 < @var2 then @var1+1 else @var2+1 end--get the min value

	while (@i < (case when @var1 < @var2 then @var2 else @var1 end))
		begin
			insert into @t values (@i)
			set @i = @i + 1
		end

	return

end

--3 Create inline function that takes Student No and returns Department Name with Student full name.
create function getStudnet(@StudentID int)
returns table

as 
return(
	select S.St_Fname + ' ' + S.St_Lname[Student Name], D.Dept_Name[Department Name]
	from student S inner join Department D
		on S.Dept_Id = D.Dept_Id
		where S.St_Id = @StudentID
	  )


--4.	Create a scalar function that takes Student ID and returns a message to user 
create function Q4(@id int)
returns varchar(100)
as
begin
    declare @fname varchar(50),
            @lname varchar(50),
            @returnstring varchar(100);

    select @fname = st_fname,
           @lname = st_lname
    from student
    where st_id = @id;

    if @fname is null and @lname is null
        set @returnstring = 'first name & last name are null';

    else if @fname is null
        set @returnstring = 'first name is null';

    else if @lname is null
        set @returnstring = 'second name is null';

    else
        set @returnstring = 'first name & last name are not null';

    return @returnstring;
end;

--5.	Create inline function that takes integer which represents manager ID and displays department name, 
--Manager Name and hiring date 

create function Q5(@ID int)
returns table
return(

select D.Dname[Department Name],E.Fname+' '+E.Lname[Manager Name],E.Hiredate[Hiring Date]
from Employee E inner join Departments D 
	on E.SSN = D.MGRSSN
	where E.SSN = @ID
)

--6.	Create multi-statements table-valued function that takes a string
create function Q6(@str varchar(20))
returns @t table(
					StudentName varchar(50)
				)
as
begin

if @str = 'first name'  
	begin
		insert into @t
		select isnull(St_Fname, '') from Student
	end

else if @str = 'second name' 
	begin 
		insert into @t
		select isnull(St_Lname,'') from Student
	end

else if @str = 'full name' 
	begin
		insert into @t
		select isnull(St_Fname,'') + ' '+isnull(St_Lname,'')[Full Name]
		from Student
	end

return 
end

--7.	Write a query that returns the Student No and Student first name without the last char
select St_Id,SUBSTRING(St_Fname,1,len(St_Fname)-1)
from Student

--8.	Wirte query to delete all grades for the students Located in SD Department 
delete from stud_course
where st_id in (select S.St_Id
				from Student S inner join Department D
					on S.Dept_Id = D.Dept_Id
				where D.Dept_Name = 'SD')

--------------------------------------------------------------------------------------------
--Bouns

--1) 
create table Employees (
    EmpID int primary key,
    EmpName varchar(50),
    OrgNode hierarchyid,
    OrgLevel as OrgNode.GetLevel()
);

insert into Employees (EmpID, EmpName, OrgNode)
values
(1, 'CEO', hierarchyid::GetRoot()),        -- root
(2, 'Manager A', hierarchyid::Parse('/1/')), 
(3, 'Employee A1', hierarchyid::Parse('/1/1/')),
(4, 'Employee A2', hierarchyid::Parse('/1/2/'))


select EmpName, OrgNode.ToString() as Path, OrgLevel
from Employees
order by OrgNode;


--output:
--CEO	/	0
--Manager A	/1/	1
--Employee A1	/1/1/	2
--Employee A2	/1/2/	2


--2)
use ITI

declare @i int = 3000

while @i <= 5999
begin
    insert into Student (st_id, st_fname, st_lname)
    values (@i, 'Jane', 'Smith')

    set @i = @i + 1
end