--1-Create a view that displays student full name, course name if the student has a grade more than 50. 
alter view V1
as
select S.St_Fname,S.St_Lname,C.Crs_Name
from Student S inner join Stud_Course SC
	on S.St_Id = SC.St_Id
	inner join Course C
	on C.Crs_Id = SC.Crs_Id
	where sc.Grade > 50


--2.	 Create an Encrypted view that displays manager names and the topics they teach. create view vstudent
create view Vstudent
with encryption
as 
select I.Ins_Name,T.Top_Name
from Department D inner join Instructor I
	on D.Dept_Manager = I.Ins_Id
	inner join Ins_Course IC
	on IC.Ins_Id = I.Ins_Id
	inner join Course C
	on C.Crs_Id = IC.Crs_Id
	inner join Topic T
	on T.Top_Id = C.Top_Id


--3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department
create view Vdept
as
select I.Ins_Name,D.Dept_Name
from Instructor I inner join Department D
	on I.Dept_Id = D.Dept_Id
	where D.Dept_Name in ('SD','Java')


--4 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--Note: Prevent the users to run the following query 
--Update V1 set st_address=’tanta’
--Where st_address=’alex’;
create view V1
as
select *
from Student 
where St_Address in ('Alex','Cairo')
with check option


--5.	Create a view that will display the project name and the number of employees work on it. 
-- “Use SD database”

create view V2
as
select P.Pname,count(*) [Number of Employees]
from Employee E inner join Works_for WF
	on WF.ESSn = E.SSN
	inner join Project P
	on P.Pnumber = WF.Pno

	group by(P.Pname)


--6.	Create index on column (Hiredate) that allow u to cluster the data in table Department. 
--What will happen?
use ITI
create clustered index i2
on Department(manager_hiredate)  --refused because the existing Primary key Dept_ID


--7.	Create index that allow u to enter unique ages in student table. What will happen?
create unique index Studnet_Age
on Student (St_Age); --it only creates it if there are no duplicated values for St_Age

--8.	Using Merge statement between the following two tables [User ID, Transaction Amount]
create table last_transactions(
						id int,
						amount int
	)

create table daily_transactions(
						id int,
						amount int
	)

insert into daily_transactions(id,amount)
values(1,1000),(2,2000),(3,1000)

insert into last_transactions(id,amount)
values(1,4000),(4,2000),(2,10000)

merge  last_transactions LT
using daily_transactions DS
on LT.id = DS.id

when matched then
	update set LT.amount = DS.amount

when not matched then
	insert (id,amount)
	values(DS.id,DS.amount);



--------------------------------------Part 2----------------------------------------------------
--1)	Create view named   “v_clerk” that will display employee#,project#, the date of hiring of all the jobs
--of the type 'Clerk'.

use SD
create view v_clerk
as
select E.EmpNo,P.ProjectNo,WO.Enter_Date
from Employee E inner join Works_On WO
	on E.EmpNo = WO.EmpNo
	inner join Project P
	on WO.ProjectNo = p.ProjectNo
	where WO.Job = 'Clerk'


--2)	 Create view named  “v_without_budget” that will display all the projects data 
--without budget
create view v_without_budget
as
select * from project
where budget is null


--3)	Create view named  “v_count “ that will display the project name and the # of jobs in it
create view v_count
as
select P.Pname, count(*)[N. of Employees]
from project P inner join Works_On WO
	on P.ProjectNo = WO.ProjectNo
	inner join Employee E 
	on	E.EmpNo = WO.EmpNo
	group by P.Pname


--4 Create view named ” v_project_p2” that will display the emp#  for the project# ‘p2’
--use the previously created view  “v_clerk”
create view v_project_p2
as
select EmpNo
from v_clerk
where ProjectNo = 2


--5)	modifey the view named  “v_without_budget”  to display all DATA in project p1 and p2
alter view v_without_budget
as
select * from project
where Pname in ('p1','p2')

--6)	Delete the views  “v_ clerk” and “v_count”
drop view v_clerk
drop view v_count


--7)	Create view that will display the emp# and emp lastname who works on dept# is ‘d2’

create view V_Emp_Dept
as
select E.EmpNo,E.EmpLname
from Employee E inner join Company.Department D
	on E.DeptNo = D.DeptNo
	where D.DeptNo = 'd2'
	
	
--	8)	Display the employee  lastname that contains letter “J”
--Use the previous view created in Q#7
select EmpLname
from V_Emp_Dept
where EmpLname like '%J%'


--9)	Create view named “v_dept” that will display the department# and department name.
create view v_dept
as
select DeptNo,DeptName
from Company.Department


--10)	using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’
insert into v_dept (DeptNo, DeptName)
values ('d4', 'Development');


--11)	Create view name “v_2006_check” that will display employee#, the project #where he works and the date of joining
--the project which must be from the first of January and the last of December 2006.

create view v_2006_check
as
select 
    E.EmpNo, P.ProjectNo, WO.Enter_Date
	from Employee E inner join Works_On WO
		on E.EmpNo = WO.EmpNo
	inner join Project P
		on P.ProjectNo = WO.ProjectNo
	where WO.Enter_Date 
		  between '2006-01-01' and '2006-12-31';