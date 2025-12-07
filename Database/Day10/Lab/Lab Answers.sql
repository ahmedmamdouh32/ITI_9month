--1.	Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 and 
-- increases it by 20% if Salary >=3000. Use company DB

DECLARE c1 CURSOR
FOR SELECT salary FROM Employee
FOR UPDATE

DECLARE @sal INT

OPEN c1
FETCH c1 INTO @sal
WHILE @@FETCH_STATUS=0
	BEGIN
		IF @sal>=3000
			UPDATE Employee
				SET Salary=@sal*1.20
			WHERE CURRENT OF c1
		ELSE IF @sal<3000
			UPDATE Employee
				SET Salary=Salary*1.10
			WHERE CURRENT OF c1
		FETCH c1 INTO @sal
	END
CLOSE c1
DEALLOCATE c1


--2.	Display Department name with its manager name using cursor. Use ITI DB

DECLARE DeptCursor CURSOR FOR
SELECT D.Dept_Name, E.EmpName
FROM Department D
INNER JOIN Employees E
ON D.Dept_Manager = E.EmpID;

DECLARE @DeptName NVARCHAR(100), 
        @ManagerName NVARCHAR(200)
     
OPEN DeptCursor;

FETCH NEXT FROM DeptCursor INTO @DeptName, @ManagerName

WHILE @@FETCH_STATUS = 0
BEGIN
    
	SELECT  @DeptName + ', Manager: ' + @ManagerName[Department - Employee];

FETCH NEXT FROM DeptCursor INTO @DeptName, @ManagerName
END

CLOSE DeptCursor;
DEALLOCATE DeptCursor;


--3.	Try to display all students first name in one cell separated by comma. Using Cursor 
USE ITI

DECLARE @allStudnetsNames varchar(MAX) = ''
DECLARE StudentNameCursor CURSOR FOR
SELECT St_Fname
FROM Student;

DECLARE @name NVARCHAR(100)
 
OPEN StudentNameCursor;

FETCH NEXT FROM StudentNameCursor INTO @name;
WHILE @@FETCH_STATUS = 0
BEGIN
    select @allStudnetsNames = isnull(@name,'')+',' + @allStudnetsNames
	FETCH NEXT FROM StudentNameCursor INTO @name;
END

CLOSE StudentNameCursor;
DEALLOCATE StudentNameCursor;

--4.	Create full, differential Backup for SD DB.
BACKUP DATABASE company_sd
TO DISK='SD.bak'
WITH DIFFERENTIAL


--5.	Create a sequence object that allow values from 1 to 10 without cycling in a 
--specific column and test it
CREATE SEQUENCE MySequence
START WITH 1
INCREMENT BY 1
MinValue 1
MaxValue 10
NO CYCLE; --default


--for testing:
DECLARE @i INT = 1;

WHILE @i <= 11   
BEGIN
    SELECT NEXT VALUE FOR MySequence AS NextNumber;
    SET @i = @i + 1;
END

--6.	Use display student’s data (ITI DB) in excel sheet
USE ITI
SELECT * FROM student

--7.	Transform all functions in day7 to Stored Procedures
--7.1)
CREATE PROCEDURE sp_getMonthName
    @date DATE
AS
BEGIN
    SELECT FORMAT(@date, 'MMMM') AS MonthName;
END

--7.2)
CREATE PROCEDURE sp_returnInBetween
    @var1 INT,
    @var2 INT
AS
BEGIN
    DECLARE @i INT;
    DECLARE @minVal INT = CASE WHEN @var1 < @var2 THEN @var1 ELSE @var2 END;
    DECLARE @maxVal INT = CASE WHEN @var1 < @var2 THEN @var2 ELSE @var1 END;

    SET @i = @minVal + 1;

    DECLARE @t TABLE (n INT);

    WHILE (@i < @maxVal)
    BEGIN
        INSERT INTO @t VALUES (@i);
        SET @i = @i + 1;
    END

    SELECT * FROM @t;
END


--7.3)
CREATE PROCEDURE sp_getStudent
    @StudentID INT
AS
BEGIN
    SELECT 
        S.St_Fname + ' ' + S.St_Lname AS [Student Name],
        D.Dept_Name AS [Department Name]
    FROM Student S
    INNER JOIN Department D ON S.Dept_Id = D.Dept_Id
    WHERE S.St_Id = @StudentID;
END

--7.4)
CREATE PROCEDURE sp_checkStudentName
    @id INT
AS
BEGIN
    DECLARE @fname VARCHAR(50),
            @lname VARCHAR(50),
            @returnstring VARCHAR(100);

    SELECT @fname = St_Fname,
           @lname = St_Lname
    FROM Student
    WHERE St_Id = @id;

    IF @fname IS NULL AND @lname IS NULL
        SET @returnstring = 'first name & last name are null';
    ELSE IF @fname IS NULL
        SET @returnstring = 'first name is null';
    ELSE IF @lname IS NULL
        SET @returnstring = 'second name is null';
    ELSE
        SET @returnstring = 'first name & last name are not null';

    SELECT @returnstring AS Message;
END


--7.5)
CREATE PROCEDURE sp_getDeptByManager
    @ID INT
AS
BEGIN
    SELECT 
        D.Dname AS [Department Name],
        E.Fname + ' ' + E.Lname AS [Manager Name],
        E.Hiredate AS [Hiring Date]
    FROM Employee E
    INNER JOIN Departments D ON E.SSN = D.MGRSSN
    WHERE E.SSN = @ID;
END


--7.6)
CREATE PROCEDURE sp_getStudentNames
    @str VARCHAR(20)
AS
BEGIN
    IF @str = 'first name'
    BEGIN
        SELECT ISNULL(St_Fname, '') AS StudentName FROM Student;
    END
    ELSE IF @str = 'second name'
    BEGIN
        SELECT ISNULL(St_Lname, '') AS StudentName FROM Student;
    END
    ELSE IF @str = 'full name'
    BEGIN
        SELECT ISNULL(St_Fname,'') + ' ' + ISNULL(St_Lname,'') AS [Full Name]
        FROM Student;
    END
END


--7.7)
CREATE PROCEDURE sp_studentFnameWithoutLastChar
AS
BEGIN
    SELECT St_Id, SUBSTRING(St_Fname, 1, LEN(St_Fname)-1) AS FnameWithoutLastChar
    FROM Student;
END


--7.8)
CREATE PROCEDURE sp_deleteGrades_SD
AS
BEGIN
    DELETE FROM Stud_Course
    WHERE St_Id IN (
        SELECT S.St_Id
        FROM Student S
        INNER JOIN Department D ON S.Dept_Id = D.Dept_Id
        WHERE D.Dept_Name = 'SD'
    );
END


--8.	Create snapshot of adventureworks_db and test it
CREATE DATABASE SnapTest2
ON
(
    NAME = 'AdventureWorks2012_Data',   -- Logical name of the source data file
    FILENAME = 'C:\snapshots\AdvWorksSnapshot.ss'            -- New file path for snapshot
)
AS SNAPSHOT OF AdventureWorks2012;
GO


--Testing:
USE AdventureWorks2012

DELETE FROM AdventureWorks2012.Production.ProductReview
WHERE productreviewid = 1

SELECT * FROM AdventureWorks2012.Production.ProductReview
SELECT * FROM SnapTest2.Production.ProductReview













