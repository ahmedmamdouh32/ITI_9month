--1.	Create a stored procedure without parameters to show the number of students per department name.[use ITI DB] 

create procedure P1
as
select D.Dept_Name,count(*)
from Student S inner join Department D
	on S.Dept_Id = D.Dept_Id
	group by D.Dept_Name
	
	
--2.	Create a stored procedure that will check for the # of employees in the project p1 if they are more than 3 
--print message to the user “'The number of employees in the project p1 is 3 or more'” if they are less display a message
--to the user “'The following employees work for the project p1'” in addition to the first name and last name of each one. 
--[Company DB] 
create procedure p2
as

declare @empCount int

select @empCount = count(*)
from Employee E inner join Works_for W
	on E.SSN = W.ESSn
	inner join Project P
	on W.Pno = P.Pnumber
	where P.Pname = 'p1'

if @empcount > 3
	select 'The number of employees in the project p1 is 3 or more'
	else 
	select 'The following employees work for the project p1'
		(
		select E.Fname,E.lname
		from Employee E inner join Works_for W
			on E.SSN = W.ESSn
			inner join Project P
			on W.Pno = P.Pnumber
			where P.Pname = 'P1' 
		)
		
		
--3.	Create a stored procedure that will be used in case there is an old employee has left the project and a new one become 
--instead of him. The procedure should take 3 parameters (old Emp. number, new Emp. number and the project number) 
--and it will be used to update works_on table. [Company DB]

create procedure p3 @old_emp int, @new_emp int, @p_num int
as

update works_for
set Essn = @new_emp
where ESSn = @old_emp AND Pno = @p_num


--4 

create table Project_Budget(
Pno nvarchar(10),
Username nvarchar(50),
ModifiedDate  date,
Budget_Old int,
Budget_New int
)

create trigger Project_Budget_Update
on project
after update
as
begin
insert into Project_Budget(Pno,Username,ModifiedDate,Budget_Old,Budget_New)
	SELECT  i.Pnumber, SYSTEM_USER,  GETDATE(), d.Budget, i.Budget                            
    FROM deleted d JOIN inserted i
		on d.Pnumber = i.Pnumber
	where  d.budget != i.budget
end	


--5.	Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
--“Print a message for user to tell him that he can’t insert a new record in that table”

use ITI
create trigger prevent_insertion
on department
instead of insert
as 
select 'You can not insert values in this table!!'


--6.	 Create a trigger that prevents the insertion Process for Employee table in March [Company DB].
create trigger prevent_insert_on_march
on Employee
instead of insert
as
	if month(getdate()) = 3
		begin
			select 'no insertion available for this table'
		end
	
	else
		begin
			insert into Employee 
			select * from inserted
		end
		

--7.	Create a trigger on student table after insert to add Row in Student Audit table (Server User Name , Date, Note) where note will be
--“[username] Insert New Row with Key=[Key Value] in table [table name]”
use ITI
create table student_notes(
	username nvarchar(50),
	Date date,
	Note nvarchar(100)
)

create trigger student_table_trigger
on student

after insert
as
begin

insert into student_notes(username,Date,Note)
select SYSTEM_USER,GETDATE(),concat(SYSTEM_USER,' inserted New Row with key = ',I.st_id,' in table Student')
from inserted I
end


--8 Create a trigger on student table instead of delete to add Row in Student Audit table (Server User Name, Date, Note) 
-- where note will be“ try to delete Row with Key=[Key Value]”
use ITI
create table student_notes(
	username nvarchar(50),
	Date date,
	Note nvarchar(100)
)

create trigger student_table_delete
on student
instead of delete
as
begin

insert into student_notes(username,Date,Note)
select SYSTEM_USER,GETDATE(),concat('Try to delete Two with key = ',I.st_id)
from deleted I
end

















